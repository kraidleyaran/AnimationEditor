using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using AnimationEditor.GameClasses;
using Cyotek.Windows.Forms;
using GameGraphicsLib;
using GameGraphicsLib.DrawableShapes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GraphicsManagerLib;
using GraphicsManagerLib.Actions;
using GraphicsManagerLib.Actions.AnimationAction;
using GraphicsManagerLib.Actions.PositionActions;
using GraphicsManagerLib.Actions.ShapeActions.RectangleActions;


namespace AnimationEditor
{
    public partial class EditAnimationWindow : Form
    {
        private const string FrameRectangleName = "frameRectangle";
        private const string CurrentTextureAnimationName = "Current Texture Animation";

        public TextureGame _textureGame;
        public AnimationGame _frameGame;
        private bool saving = false;
        private string originalName = "";

        private GraphicsManager animationManager;
        private GraphicsManager textureManager;

        private List<string> _animationNames;

        private List<BinaryTexture> _binaryTextures;

        public Animation ReturnAnimation;

        public bool NewAnimation = false;
        private bool _frameGameLoaded = false;
        //Constructor for New Animation
        public EditAnimationWindow(List<BinaryTexture> binaryTextures, List<string> animationNames)
        {
            InitializeComponent();            
            _animationNames = animationNames;
            NewAnimation = true;
            _binaryTextures = binaryTextures;
            
        }
        //Constructor for Existing animation
        public EditAnimationWindow(List<BinaryTexture> binaryTextures, List<string> animationNames, Animation animation)
        {
            InitializeComponent();
            _animationNames = animationNames;
            ReturnAnimation = animation;
            _binaryTextures = binaryTextures;
        }
        //Have to start a game on the OnShown event, do a bunch of game stuff while we're at it.
        public void OnShown_Window(object sender, EventArgs e)
        {
            if (_binaryTextures.Count <= 0)
            {
                MessageBox.Show("You must load sprite sheets before creating an animation", "No sprite sheets",
                    MessageBoxButtons.OK);
                Close();
                DialogResult = DialogResult.Cancel;
                return;
            }
            DialogResult = DialogResult.Cancel;
            DisableFrameButtons();
            panel_XNA.Controls.Add(pictureBox_TextureDisplay);
            panel_FrameDisplay.Controls.Add(pictureBox_FrameDisplay);
            string textureName = "";
            panel_XNA.AutoScroll = true;

            _textureGame = new TextureGame(pictureBox_TextureDisplay.Handle, this, pictureBox_TextureDisplay, new Vector2(pictureBox_TextureDisplay.Width, pictureBox_TextureDisplay.Height), lbl_MouseState);
            textureManager = new GraphicsManager(_textureGame.gameGraphics);

            _textureGame.gameForm.GotFocus += delegate(object o, EventArgs args)
            {
                this.Focus();
            };
            if (NewAnimation)
            {
                NewNameWindow newAnimationNameWindow = new NewNameWindow(_animationNames, "Animation");
                newAnimationNameWindow.FormClosed += delegate(object o, FormClosedEventArgs args)
                {
                    switch (newAnimationNameWindow.DialogResult)
                    {
                        case DialogResult.OK:
                            ReturnAnimation = new Animation(newAnimationNameWindow.ReturnName, "", 0, 1, 1, Vector2.Zero,
                                Vector2.Zero, 1);
                            txtBox_AnimationName.Text = ReturnAnimation.Name;
                            SetAnimationFields(ReturnAnimation);
                            originalName = newAnimationNameWindow.ReturnName;
                            return;
                        case DialogResult.Cancel:
                            DialogResult = DialogResult.Cancel;
                            return;
                        default:
                            return;
                    }
                };
                newAnimationNameWindow.ShowDialog();
                if (newAnimationNameWindow.DialogResult == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }
                List<string> textureNames = _binaryTextures.Select(texture => texture.Name).ToList();
                
                SetSpriteSheetWindow setTextureWindow = new SetSpriteSheetWindow(textureNames);
                switch (setTextureWindow.ShowDialog())
                {
                    case DialogResult.OK:
                        textureName = setTextureWindow.SelectedTexture;
                        ReturnAnimation.Texture = textureName;
                        break;
                    case DialogResult.Cancel:
                        DialogResult = DialogResult.Cancel;
                        Close();
                        return;
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                BinaryTexture texture = _binaryTextures.FirstOrDefault(t => t.Name == ReturnAnimation.Texture);
                if (texture == null)
                {
                    switch(MessageBox.Show("Sprite sheet is invalid, please choose a new spritesheet", "Invalid SpriteSheet", MessageBoxButtons.OKCancel))
                    {
                        case DialogResult.OK:
                            List<string> textureNames = _binaryTextures.Select(txt => txt.Name).ToList();
                            SetSpriteSheetWindow setSpriteSheet = new SetSpriteSheetWindow(textureNames);
                            switch (setSpriteSheet.ShowDialog())
                            {
                                case DialogResult.OK:
                                    ReturnAnimation.Texture = setSpriteSheet.SelectedTexture;
                                    break;
                                case DialogResult.Cancel:
                                    DialogResult = DialogResult.Cancel;
                                    Close();
                                    return;                                    
                            }
                            break;
                        case DialogResult.Cancel:
                            DialogResult = DialogResult.Cancel;
                            Close();
                            return;
                    }
                    
                }
                originalName = ReturnAnimation.Name;
            }
            SetAnimationFields(ReturnAnimation);
            _textureGame.gameGraphics.GraphicsManager.DeviceCreated += delegate(object o, EventArgs args)
            {
                foreach (BinaryTexture texture in _binaryTextures)
                {
                    _textureGame.gameGraphics.textureManager.Textures.Add(texture.Name, TextureManager.ConvertDataToTexture(texture, _textureGame.gameGraphics.GraphicsManager.GraphicsDevice));
                    Animation textureAnimation = new Animation(texture.Name, texture.Name, 0, 1, 1, new Vector2(0, 0), new Vector2(0, 0), 1);
                    textureAnimation.AddFrame(new Frame(new GameRectangle(0, 0, texture.Width, texture.Height)));
                    _textureGame.gameGraphics.AddDrawable(textureAnimation);
                }
                _textureGame.gameGraphics.AddToDrawList(new DrawParam(CurrentTextureAnimationName, ReturnAnimation.Texture, Vector2.Zero, DrawnType.Animation));
                
                BinaryTexture animationTexture = _binaryTextures.FirstOrDefault(t => t.Name == ReturnAnimation.Texture);
                if (animationTexture != null)
                {
                    if (animationTexture.Height > panel_XNA.Height || animationTexture.Width > panel_XNA.Width)
                    {
                        panel_XNA.AutoScrollMinSize = new Size(animationTexture.Width, animationTexture.Height);
                        pictureBox_TextureDisplay.Location = new System.Drawing.Point(0, 0);
                    }
                }
                
                DrawnRectangle frameRectangle = new DrawnRectangle
                {
                    Name = FrameRectangleName,
                    PositionX = 0,
                    PositionY = 0,
                    Size = new Size(0, 0),
                    Thickness = 1,
                    Color = GameGraphics.ConvertSystemColorToXNA(System.Drawing.Color.Fuchsia)
                };
                _textureGame.gameGraphics.AddDrawable(frameRectangle);
                _textureGame.gameGraphics.AddToDrawList(new DrawParam(FrameRectangleName, FrameRectangleName,new Vector2(frameRectangle.PositionX, frameRectangle.PositionY), DrawnType.Shape));
                MakeTextureLoopFrame(CurrentTextureAnimationName);
                SetAnimationTexture(textureName);
            };
            // This is here to prevent _textueGame from malfunctioning when tabbing through text fields. Not sure why, probably should look at that later.
            SendKeys.Send("{TAB}");
            
            
             _textureGame.Run();
            

        }
        //Send actions to make sure that the Texture continues displaying
        private void MakeTextureLoopFrame(string textureName)
        {
            FrameAction frameAction = new FrameAction
            {
                Name = textureName,
                Drawable = textureName,
                Value = 1
            };
            StatusAction statusAction = new StatusAction
            {
                Name = textureName,
                Drawable = textureName,
                Value = AnimationStatus.Paused
            };
            LoopAction loopActon = new LoopAction
            {
                Name = textureName,
                Drawable = textureName,
                Value = true
            };

            textureManager.ExecuteAction(statusAction);
            textureManager.ExecuteAction(frameAction);
            textureManager.ExecuteAction(loopActon);
        }
        //No longer needed, meant to place in OnClosed event
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            /*
            if (_textureGame != null && _textureGame.IsActive)
            {
                _textureGame.CloseGame();    
            }
            if (_frameGame != null)
            {
                _frameGame.CloseGame();
            }
             */
        }
        //When something is selected from the listbox, display it on the Current Frame screen
        private void listBox_Frames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Action action = () =>
            {
                if (listBox_Frames.SelectedItem == null)
                {
                    DisableFrameButtons();
                    return;
                }

                EnableFrameButtons();

                int selectedFrame = (int) listBox_Frames.SelectedItem;
                SetFieldsFromFrame(ReturnAnimation.Frames[selectedFrame]);
                lbl_FrameNumber.Text = selectedFrame.ToString();
                float width = ReturnAnimation.Frames[selectedFrame].TextureSource.Width;
                float height = ReturnAnimation.Frames[selectedFrame].TextureSource.Height;

                _frameGame.gameGraphics.ClearDrawList();

                Vector2 position = Vector2.Zero;


                if (width <= panel_FrameDisplay.Width && height <= panel_FrameDisplay.Height)
                {
                    Vector2 center =
                        StaticMethods.GetCenter(new Vector2(((width)*ReturnAnimation.Scale), (height)*ReturnAnimation.Scale));
                    position = StaticMethods.GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
                }
                if (width > panel_FrameDisplay.Width || height > panel_FrameDisplay.Height)
                {
                    panel_FrameDisplay.AutoScrollMinSize = new Size((int) width, (int) height);
                    pictureBox_FrameDisplay.Location = new System.Drawing.Point(0, 0);
                }

                if (!_frameGame.gameGraphics.DoesDrawableExist(ReturnAnimation.Name))
                {
                    _frameGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name,
                        position, DrawnType.Animation));
                }
                else
                {
                    _frameGame.gameGraphics.UpdateDrawPosition(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name,
                        position, DrawnType.Animation));
                }
                Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
                drawAnimation.Frame = selectedFrame;
                _frameGame.gameGraphics.SetLoadedDrawn(drawAnimation);
                SetFrameData(saving);

                FrameAction frameAction = new FrameAction
                {
                    Name = ReturnAnimation.Name,
                    Drawable = ReturnAnimation.Name,
                    Value = selectedFrame
                };
                StatusAction statusAction = new StatusAction
                {
                    Name = ReturnAnimation.Name,
                    Drawable = ReturnAnimation.Name,
                    Value = AnimationStatus.Paused
                };
                LoopAction loopActon = new LoopAction
                {
                    Name = ReturnAnimation.Name,
                    Drawable = ReturnAnimation.Name,
                    Value = true
                };


                animationManager.ExecuteAction(statusAction);
                animationManager.ExecuteAction(frameAction);
                animationManager.ExecuteAction(loopActon);
            };
            if (!_frameGameLoaded)
            {
                LoadFrameGame(action);
                return;
            }
            action();
        }
        //Method for grouping starting the frame game since it can be done in various places
        private void LoadFrameGame()
        {
            _frameGame = new AnimationGame(pictureBox_FrameDisplay.Handle, this, pictureBox_FrameDisplay, new Vector2(pictureBox_FrameDisplay.Width, pictureBox_FrameDisplay.Height));
            animationManager = new GraphicsManager(_frameGame.gameGraphics);
            pictureBox_TextureDisplay.Width = _frameGame.gameGraphics.GraphicsManager.PreferredBackBufferWidth;
            pictureBox_TextureDisplay.Height = _frameGame.gameGraphics.GraphicsManager.PreferredBackBufferHeight;

            _frameGame.gameForm.GotFocus += delegate(object o, EventArgs args)
            {
                this.Focus();
            };
            _frameGameLoaded = true;
            _frameGame.gameGraphics.GraphicsManager.DeviceCreated += delegate(object o, EventArgs args)
            {
                foreach (BinaryTexture texture in _binaryTextures)
                {
                    _frameGame.gameGraphics.textureManager.Textures.Add(texture.Name, TextureManager.ConvertDataToTexture(texture, _frameGame.gameGraphics.GraphicsManager.GraphicsDevice));
                }
            };
            Vector2 position = Vector2.Zero;
            if (ReturnAnimation.Frames[1].TextureSource.Width <= panel_FrameDisplay.Width || ReturnAnimation.Frames[1].TextureSource.Height <= panel_FrameDisplay.Height)
            {
                Vector2 center = StaticMethods.GetCenter(new Vector2(((ReturnAnimation.Frames[1].TextureSource.Width) * ReturnAnimation.Scale), (ReturnAnimation.Frames[1].TextureSource.Height) * ReturnAnimation.Scale));
                position = StaticMethods.GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
            }
            _frameGame.gameGraphics.AddDrawable(ReturnAnimation);
            _frameGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name, position,DrawnType.Animation));
            _frameGame.Run();
        }
        //Same as LoadFrameGame, but you're able to run some stuff before starting the game. This way things for the game can be created, but  other things can be done right before we start the game since nothing can be done after less it be an event
        private void LoadFrameGame(Action action)
        {
            _frameGame = new AnimationGame(pictureBox_FrameDisplay.Handle, this, pictureBox_FrameDisplay, new Vector2(pictureBox_FrameDisplay.Width, pictureBox_FrameDisplay.Height));
            animationManager = new GraphicsManager(_frameGame.gameGraphics);
            pictureBox_TextureDisplay.Width = _frameGame.gameGraphics.GraphicsManager.PreferredBackBufferWidth;
            pictureBox_TextureDisplay.Height = _frameGame.gameGraphics.GraphicsManager.PreferredBackBufferHeight;

            _frameGame.gameForm.GotFocus += delegate(object o, EventArgs args)
            {
                this.Focus();
            };
            _frameGameLoaded = true;
            _frameGame.gameGraphics.GraphicsManager.DeviceCreated += delegate(object o, EventArgs args)
            {
                foreach (BinaryTexture texture in _binaryTextures)
                {
                    _frameGame.gameGraphics.textureManager.Textures.Add(texture.Name, TextureManager.ConvertDataToTexture(texture, _frameGame.gameGraphics.GraphicsManager.GraphicsDevice));
                }
            };
            Vector2 position = Vector2.Zero;
            if (ReturnAnimation.Frames[1].TextureSource.Width <= panel_FrameDisplay.Width || ReturnAnimation.Frames[1].TextureSource.Height <= panel_FrameDisplay.Height)
            {
                Vector2 center = StaticMethods.GetCenter(new Vector2(((ReturnAnimation.Frames[1].TextureSource.Width) * ReturnAnimation.Scale), (ReturnAnimation.Frames[1].TextureSource.Height) * ReturnAnimation.Scale));
                position = StaticMethods.GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
            }
            _frameGame.gameGraphics.AddDrawable(ReturnAnimation);
            _frameGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name, position, DrawnType.Animation));
            action();
            _frameGame.Run();
        }
        //Add frame button click
        private void btn_AddFrame_Click(object sender, EventArgs e)
        {
            AddFrame(new Frame(new GameRectangle(0,0,ReturnAnimation.DefaultWidth,ReturnAnimation.DefaultHeight)));
            if (!_frameGameLoaded)
            {
                LoadFrameGame();
            }
        }
        //Add frame to ReturnAnimation (aka, the current animaion). If FrameGame is started and has said animation, update it too.
        private void AddFrame(Frame frame)
        {
            ReturnAnimation.AddFrame(frame);
            if (_frameGame != null && _frameGame.gameGraphics.DoesDrawableExist(ReturnAnimation.Name))
            {
                Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
                drawAnimation.AddFrame(frame);
                _frameGame.gameGraphics.SetLoadedDrawn(drawAnimation);
            }
            listBox_Frames.Items.Add(listBox_Frames.Items.Count + 1);
            lbl_CurrentFrameCount.Text = ReturnAnimation.FrameCount.ToString();
        }
        //Remove from ReturnAnimation, same shit about Frame game. Only difference is that there's some extra code to take care of the rest of the frames if a frame is removed.
        private bool RemoveFrame(int frame)
        {
            if (frame > ReturnAnimation.FrameCount) return false;
            if (_frameGame != null && _frameGame.gameGraphics.DoesDrawableExist(ReturnAnimation.Name))
            {
                Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
                drawAnimation.RemoveFrame(frame);
                _frameGame.gameGraphics.SetLoadedDrawn(drawAnimation);
            }
            listBox_Frames.Items.Remove(frame);
            foreach (int currentFrame in listBox_Frames.Items.Cast<object>().Select(item => Int32.Parse(item.ToString())).Where(currentFrame => currentFrame > frame).ToList())
            {
                listBox_Frames.Items.Remove(currentFrame);
                listBox_Frames.Items.Add(currentFrame - 1);
            }
            bool returnBool = ReturnAnimation.RemoveFrame(frame);
            lbl_CurrentFrameCount.Text = ReturnAnimation.FrameCount.ToString();
            return returnBool;
        }
        //Set text boxes to frame properties
        private void SetFieldsFromFrame(Frame frame)
        {
            txtBox_FrameX.Text = frame.TextureSource.X.ToString();
            txtBox_FrameY.Text = frame.TextureSource.Y.ToString();
            txtBox_FrameWidth.Text = frame.TextureSource.Width.ToString();
            txtBox_FrameHeight.Text = frame.TextureSource.Height.ToString();
        }
        //Set the texture for the animation. Although this doesn't actually do that seeing how the actual animattion is never affected. I guess i'm assuming the texture is being assigned before this.
        private void SetAnimationTexture(string textureName)
        {
            _textureGame.gameGraphics.AddToDrawList(new DrawParam(textureName, textureName, new Vector2(0, 0), DrawnType.Animation));
            lbl_TextureName.Text = textureName;    
        }
        //Set text boxes to Animation properties
        private void SetAnimationFields(Animation animation)
        {
            txtBox_AnimationName.Text = animation.Name;
            txtBox_Depth.Text = animation.Depth.ToString();
            txtBox_Scale.Text = animation.Scale.ToString();
            txtBox_Speed.Text = animation.FramesPerSecond.ToString();
            txtBox_DefaultHeight.Text = animation.DefaultHeight.ToString();
            txtBox_DefaultWidth.Text = animation.DefaultWidth.ToString();
            if (animation.FrameCount <= 0) return;
            for (int i = 1; i <= animation.FrameCount; i++)
            {
                listBox_Frames.Items.Add(i);
            }
            lbl_CurrentFrameCount.Text = animation.FrameCount.ToString();
        }
        // Set frame button click
        private void btn_SetFrame_Click(object sender, EventArgs e)
        {
            SetFrameData(saving);
            _frameGame.RunOneFrame();
        }
        //Preview button click
        private void btn_Preview_Click(object sender, EventArgs e)
        {
            BinaryTexture texture = _binaryTextures.FirstOrDefault(t => t.Name == ReturnAnimation.Texture);
            if (texture == null)
            {
                MessageBox.Show("Invalid texutre", "Invalid Texture", MessageBoxButtons.OK);
                return;
            }
            if (ReturnAnimation.FrameCount == 0)
            {
                MessageBox.Show("Animation must have a frame before you can preview", "No frames on animation",MessageBoxButtons.OK);
                return;
            }
            SetAnimation();
            PreviewAnimationWindow previewAnimation = new PreviewAnimationWindow(ReturnAnimation, texture);
            previewAnimation.ShowDialog();
        }
        // Remove frame button click
        private void btn_RemoveFrame_Click(object sender, EventArgs e)
        {
            if (listBox_Frames.SelectedItem == null) return;
            int selectedItem = Int32.Parse(listBox_Frames.SelectedItem.ToString());
            switch (selectedItem)
            {
                case 1:
                    if (ReturnAnimation.FrameCount == 1)
                    {
                        MessageBox.Show("Animation must have at least 1 frame");
                        return;
                    }
                    break;
                case 0:
                    return;
            }
            RemoveFrame(selectedItem);
            if (!_frameGameLoaded)
            {
                LoadFrameGame();
            }
        }
        //Set Animation button click
        private void btn_SetAnimation_Click(object sender, EventArgs e)
        {
            SetAnimation();
        }
        //Set Animation properties equal to text in textbox fields
        private void SetAnimation()
        {
            DialogResult = DialogResult.OK;
            ReturnAnimation.Scale = float.Parse(txtBox_Scale.Text);
            ReturnAnimation.Depth = float.Parse(txtBox_Depth.Text);
            ReturnAnimation.FramesPerSecond = Int32.Parse(txtBox_Speed.Text);
            ReturnAnimation.DefaultHeight = Int32.Parse(txtBox_DefaultHeight.Text);
            ReturnAnimation.DefaultWidth = Int32.Parse(txtBox_DefaultWidth.Text);

            if (!_frameGameLoaded) return;

            Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
            drawAnimation.Scale = float.Parse(txtBox_Scale.Text);
            drawAnimation.Depth = float.Parse(txtBox_Depth.Text);
            drawAnimation.FramesPerSecond = Int32.Parse(txtBox_Speed.Text);
            drawAnimation.DefaultHeight = Int32.Parse(txtBox_DefaultHeight.Text);
            drawAnimation.DefaultWidth = Int32.Parse(txtBox_DefaultWidth.Text);

            _frameGame.gameGraphics.SetLoadedDrawn(drawAnimation);
        }
        //Set Spritesheet button click
        private void btn_SetSpriteSheet_Click(object sender, EventArgs e)
        {
            List<string> textureNames = _binaryTextures.Select(txt => txt.Name).ToList();
            SetSpriteSheetWindow setSpriteSheet = new SetSpriteSheetWindow(textureNames, ReturnAnimation.Texture);
            switch (setSpriteSheet.ShowDialog())
            {
                case DialogResult.OK:
                    ReturnAnimation.Texture = setSpriteSheet.SelectedTexture;
                    if (_frameGame != null && _frameGame.gameGraphics.DoesDrawableExist(ReturnAnimation.Name))
                    {
                        Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
                        drawAnimation.Texture = setSpriteSheet.SelectedTexture;
                        _frameGame.gameGraphics.SetLoadedDrawn(drawAnimation);
                    }
                    _textureGame.gameGraphics.ClearDrawList();
                    _textureGame.gameGraphics.AddToDrawList(new DrawParam(CurrentTextureAnimationName,ReturnAnimation.Texture, new Vector2(0, 0), DrawnType.Animation));
                    MakeTextureLoopFrame(CurrentTextureAnimationName);
                    lbl_TextureName.Text = ReturnAnimation.Texture;
                    _textureGame.RunOneFrame();

                    return;
                case DialogResult.Cancel:
                    return;
            }
        }
        //Set textbox data to frame properties, then display new texture frame
        private void SetFrameData(bool saving)
        {
            DialogResult = DialogResult.OK;
            if (listBox_Frames.SelectedItem == null) return;
            int x = Int32.Parse(txtBox_FrameX.Text);
            int y = Int32.Parse(txtBox_FrameY.Text);
            int width = Int32.Parse(txtBox_FrameWidth.Text);
            int height = Int32.Parse(txtBox_FrameHeight.Text);
            int frame = Int32.Parse(lbl_FrameNumber.Text);
            Frame setFrame = new Frame(new GameRectangle(x, y, width, height));
            ReturnAnimation.SetFrame(frame, setFrame);
            if (saving) return;
            Vector2 position = Vector2.Zero;
            
            if (width <= panel_FrameDisplay.Width || height <= panel_FrameDisplay.Height)
            {
                Vector2 center = StaticMethods.GetCenter(new Vector2(((width) * ReturnAnimation.Scale), (height) * ReturnAnimation.Scale));
                position = StaticMethods.GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
            }
            if (width > panel_FrameDisplay.Width || height > panel_FrameDisplay.Height)
            {
                panel_FrameDisplay.AutoScrollMinSize = new Size((int)width, (int)height);
                pictureBox_FrameDisplay.Location = new System.Drawing.Point(0, 0);
            }
            if (_frameGame.gameGraphics.DoesDrawableExist(ReturnAnimation.Name))
            {
                Animation drawnAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
                drawnAnimation.SetFrame(frame, setFrame);
                _frameGame.gameGraphics.SetLoadedDrawn(drawnAnimation);
            }
            else
            {
                _frameGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name, position, DrawnType.Animation));
                return;
            }
            _frameGame.gameGraphics.UpdateDrawPosition(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name, position, DrawnType.Animation));

            RectangleHeightAction rectangleHeightAction = new RectangleHeightAction
            {
                Name = FrameRectangleName,
                Drawable = FrameRectangleName,
                Value = height
            };
            RectangleWidthAction rectangleWidthAction = new RectangleWidthAction
            {
                Name = FrameRectangleName,
                Drawable = FrameRectangleName,
                Value = width
            };
            PositionXAction rectanglePositionXAction = new PositionXAction
            {
                Name = FrameRectangleName,
                Drawable = FrameRectangleName,
                Value = x
            };
            PositionYAction rectanglePositionYAction = new PositionYAction
            {
                Name = FrameRectangleName,
                Drawable = FrameRectangleName,
                Value = y
            };
            textureManager.ExecuteAction(rectanglePositionXAction);
            textureManager.ExecuteAction(rectanglePositionYAction);
            textureManager.ExecuteAction(rectangleWidthAction);
            textureManager.ExecuteAction(rectangleHeightAction);
            _textureGame.RunOneFrame();
        }
        //Grid Tool button click
        private void btn_GridTool_Click(object sender, EventArgs e)
        {
            int height = Int32.Parse(txtBox_DefaultHeight.Text);
            int width = Int32.Parse(txtBox_DefaultWidth.Text);
            GridFrameTool newGridWindow = new GridFrameTool(height, width);
            switch (newGridWindow.ShowDialog())
            {
                case DialogResult.OK:
                for (int i = 1; i <= newGridWindow.ReturnFrames.Count; i++)
                {
                    AddFrame(newGridWindow.ReturnFrames[i]);
                }
                    break;
                default:
                    return;
            }
        }
        //Clone Frame button click
        private void btn_CloneFrame_Click(object sender, EventArgs e)
        {
            if (listBox_Frames.SelectedItem == null) return;
            int selectedFrameNumber = Int32.Parse(listBox_Frames.SelectedItem.ToString());
            Frame selectedFrame = ReturnAnimation.Frames[selectedFrameNumber];
            AddFrame(new Frame(new GameRectangle(selectedFrame.TextureSource.X, selectedFrame.TextureSource.Y, selectedFrame.TextureSource.Width, selectedFrame.TextureSource.Height)));
        }
        //Texture background color button click
        private void btn_TextureBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorPickerDialog colorDialog = new ColorPickerDialog();
            DialogResult result = colorDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    _textureGame.BackgroundColor = GameGraphics.ConvertSystemColorToXNA(colorDialog.Color);
                    _textureGame.RunOneFrame();
                    return;
                default:
                    return;
            }
        }
        //Frame background color button click
        private void btn_FrameBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorPickerDialog colorDialog = new ColorPickerDialog();
            DialogResult result = colorDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    _frameGame.BackgroundColor = GameGraphics.ConvertSystemColorToXNA(colorDialog.Color);
                    return;
                default:
                    return;
            }
        }
        //For displaying current mouse X,Y over texture
        private void pictureBox_TextureDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            _textureGame.RunOneFrame();
        }
        //Frame color button click
        private void btn_FrameColor_Click(object sender, EventArgs e)
        {
            ColorPickerDialog colorDialog = new ColorPickerDialog();
            DialogResult result = colorDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    ColorAction action = new ColorAction
                    {
                        Name = "Frame color",
                        Drawable = FrameRectangleName,
                        Value = GameGraphics.ConvertSystemColorToXNA(colorDialog.Color)
                    };
                    textureManager.ExecuteAction(action);
                    _textureGame.RunOneFrame();
                    return;
                default:
                    return;
            }
        }
        //Prevent anything but numbers and a decimal from being typed
        private void txtBox_Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            var textBox = sender as TextBox;
            if (textBox != null && ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
            }
        }
        //Prevent anything but numbers from being typed (including decimal)
        private void txtBox_Numbers_NoDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Set frame number button. Have to reorganize frames for this to work. Get frame, then move all frames up 1 from where it wants to be inserted.
        private void btn_SetFrameNumber_Click(object sender, EventArgs e)
        {
            SetFrameNumber setFrameNumber = new SetFrameNumber();
            switch (setFrameNumber.ShowDialog())
            {
                case DialogResult.OK:
                    int currentFrameNumber = Int32.Parse(listBox_Frames.SelectedItem.ToString());
                    Frame currentFrame = ReturnAnimation.Frames[currentFrameNumber];
                    Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
                    for (int i = currentFrameNumber; i > setFrameNumber.ReturnFrameNumber; i--)
                    {
                        ReturnAnimation.Frames[i] = ReturnAnimation.Frames[i - 1];
                        drawAnimation.Frames[i] = drawAnimation.Frames[i - 1];
                    }
                    ReturnAnimation.Frames[setFrameNumber.ReturnFrameNumber] = currentFrame;
                    drawAnimation.Frames[setFrameNumber.ReturnFrameNumber] = currentFrame;

                    _textureGame.gameGraphics.SetLoadedDrawn(drawAnimation);
                    return;
                case DialogResult.Cancel:
                    return;
            }
        }
        //Exit button, doesn't save but checks for differences in fields. Also checks for name stuff.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalName != ReturnAnimation.Name && _animationNames.Contains(txtBox_AnimationName.Text))
            {
                MessageBox.Show(
                    "\" " + txtBox_AnimationName.Text +"\" animation name already exists. Give animation a different name before exiting","Animation name already exists", MessageBoxButtons.OK);
                return;
            }
            if (!CheckAnimationFieldsForDifference() || !CheckFrameFieldsForDifference()) return;
            Close();
        }
        //Make sure there's no difference between animation fields and ReturnAnimation object
        private bool CheckAnimationFieldsForDifference()
        {
            List<string> unSavedFields = new List<string>();
            if (ReturnAnimation.Name != txtBox_AnimationName.Text) unSavedFields.Add("Animation Name");
            if (ReturnAnimation.Depth != float.Parse(txtBox_Depth.Text)) unSavedFields.Add("Animation Depth");
            if (ReturnAnimation.Scale != float.Parse(txtBox_Scale.Text)) unSavedFields.Add("Animation Scale");
            if (ReturnAnimation.FramesPerSecond != float.Parse(txtBox_Speed.Text)) unSavedFields.Add("Animation Speed");
            if (ReturnAnimation.DefaultHeight != Int32.Parse(txtBox_DefaultHeight.Text)) unSavedFields.Add("Animation Default Height");
            if (ReturnAnimation.DefaultWidth != Int32.Parse(txtBox_DefaultWidth.Text)) unSavedFields.Add("Animation Default Width");
            if (ReturnAnimation.FrameCount != Int32.Parse(lbl_CurrentFrameCount.Text)) unSavedFields.Add("Animation Frame Count");
            if (unSavedFields.Count > 0)
            {
                string unSavedFields_String = unSavedFields.Aggregate("", (current, field) => current + "\n" + field);
                DialogResult result = MessageBox.Show("The following fields are not saved:\n " + unSavedFields_String + "\n Do you wish to discard these changes?", "Unsaved Fields",
                    MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        return true;
                    case DialogResult.No:
                        return false;
                    default:
                        return false;
                }
            }
            return true;
        }
        //Make sure there's no differences between Frame fields and selected frame.
        private bool CheckFrameFieldsForDifference()
        {
            if (listBox_Frames.SelectedItem == null) return true;
            List<string> unSavedFields = new List<string>();
            int currentFrame = Int32.Parse(listBox_Frames.SelectedItem.ToString());
            Frame frame = ReturnAnimation.Frames[currentFrame];
            if (frame.TextureSource.X != Int32.Parse(txtBox_FrameX.Text)) unSavedFields.Add("Frame X");
            if (frame.TextureSource.Y != Int32.Parse(txtBox_FrameY.Text)) unSavedFields.Add("Frame Y");
            if (frame.TextureSource.Height != Int32.Parse(txtBox_FrameHeight.Text)) unSavedFields.Add("Frame Height");
            if (frame.TextureSource.Width != Int32.Parse(txtBox_FrameWidth.Text)) unSavedFields.Add("Frame Width");
            if (unSavedFields.Count > 0)
            {
                string unSavedFields_String = unSavedFields.Aggregate("", (current, field) => current + "\n" + field);
                DialogResult result = MessageBox.Show("The following fields are not saved:\n " + unSavedFields_String + "\n Do you wish to discard these changes?", "Unsaved Fields",
                    MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        return true;
                    case DialogResult.No:
                        return false;
                    default:
                        return false;
                }
            }
            return true;
        }
        // Check Name, save data, close.
        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalName != ReturnAnimation.Name && _animationNames.Contains(txtBox_AnimationName.Text))
            {
                MessageBox.Show(
                    "\" " + txtBox_AnimationName.Text + "\" animation name already exists. Give animation a different name before exiting", "Animation name already exists", MessageBoxButtons.OK);
                return;
            }
            saving = true;
            SetFrameData(saving);
            SetAnimation();
            if (!CheckAnimationFieldsForDifference() || !CheckFrameFieldsForDifference()) return;
            Close();
        }
        // Check name, save data.
        private void btn_SaveAll_Click(object sender, EventArgs e)
        {
            if (originalName != ReturnAnimation.Name && _animationNames.Contains(txtBox_AnimationName.Text))
            {
                MessageBox.Show(
                    "\" " + txtBox_AnimationName.Text + "\" animation name already exists. Give animation a different name before exiting", "Animation name already exists", MessageBoxButtons.OK);
                return;
            }
            saving = true;
            SetFrameData(saving);
            SetAnimation();
        }

        private void btn_SaveAll_KeyDown(object sender, KeyEventArgs e)
        {

        }
        //Save everything when Ctrl+S is hit. Not sure how well this works.
        private void EditAnimationWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                SetFrameData(saving);
                SetAnimation();
                e.SuppressKeyPress = true;  // Stops bing! Also sets handled which stop event bubbling
            }
        }
        //I know I said I used a different event before so this is kind of weird. Whatever. You have to close the games for the form to be closed. There are states where either could be null
        private void EditAnimationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_frameGame != null)
            {
                _frameGame.CloseGame();    
            }
            if (_textureGame != null)
            {
                _textureGame.CloseGame();    
            }
        }
        //Disable frame buttons
        private void DisableFrameButtons()
        {
            btn_SetFrame.Enabled = false;
            btn_CloneFrame.Enabled = false;
            btn_SetFrameNumber.Enabled = false;
            btn_RemoveFrame.Enabled = false;
        }
        //Enable frame buttons
        private void EnableFrameButtons()
        {
            btn_SetFrame.Enabled = true;
            btn_CloneFrame.Enabled = true;
            btn_SetFrameNumber.Enabled = true;
            btn_RemoveFrame.Enabled = true;
        }
    }
}
