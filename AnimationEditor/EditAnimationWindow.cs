using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnimationEditor.GameClasses;
using GameGraphicsLib;
using GameGraphicsLib.DrawableShapes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GraphicsManagerLib;
using GraphicsManagerLib.Actions;
using GraphicsManagerLib.Actions.AnimationAction;
using GraphicsManagerLib.Actions.PositionActions;
using GraphicsManagerLib.Actions.ShapeActions.RectangleActions;
using System.Threading;
using System.Threading.Tasks;


namespace AnimationEditor
{
    public partial class EditAnimationWindow : Form
    {
        private static string frameRectangleName = "frameRectangle";
        private TextureGame _textureGame;
        private AnimationGame _frameGame;

        private GraphicsManager animationManager;
        private GraphicsManager textureManager;

        private TextureManager _textureManager;

        private List<string> _animationNames;

        private List<BinaryTexture> _binaryTextures;

        public Animation ReturnAnimation;

        public bool _newAnimation = false;
        private bool _frameGameLoaded = false;
        public EditAnimationWindow(List<BinaryTexture> binaryTextures, List<string> animationNames)
        {
            InitializeComponent();            
            _animationNames = animationNames;
            _newAnimation = true;
            _binaryTextures = binaryTextures;
            
        }

        public EditAnimationWindow(List<BinaryTexture> binaryTextures, List<string> animationNames, Animation animation)
        {
            InitializeComponent();
            _animationNames = animationNames;
            ReturnAnimation = animation;
            _binaryTextures = binaryTextures;
        }

        public void OnShown_Window(object sender, EventArgs e)
        {
            btn_SetFrame.Enabled = false;
            panel_XNA.Controls.Add(pictureBox_TextureDisplay);
            panel_FrameDisplay.Controls.Add(pictureBox_FrameDisplay);
            string textureName = "";
            panel_XNA.AutoScroll = true;

            _textureGame = new TextureGame(pictureBox_TextureDisplay.Handle, this, pictureBox_TextureDisplay, new Vector2(pictureBox_TextureDisplay.Width, pictureBox_TextureDisplay.Height));
            textureManager = new GraphicsManager(_textureGame.gameGraphics);
            pictureBox_TextureDisplay.Width = _textureGame.gameGraphics.GraphicsManager.PreferredBackBufferWidth;
            pictureBox_TextureDisplay.Height = _textureGame.gameGraphics.GraphicsManager.PreferredBackBufferHeight;

            _textureGame.gameForm.GotFocus += delegate(object o, EventArgs args)
            {
                this.Focus();
            };
            if (_newAnimation)
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
                            return;
                        case DialogResult.Cancel:
                            Close();
                            return;
                        default:
                            return;
                    }
                };
                newAnimationNameWindow.ShowDialog();
                if (newAnimationNameWindow.DialogResult == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
                List<string> textureNames = _binaryTextures.Select(texture => texture.Name).ToList();
                SetSpriteSheetWindow setTextureWindow = new SetSpriteSheetWindow(textureNames);
                setTextureWindow.ShowDialog();
                textureName = setTextureWindow.SelectedTexture;
                ReturnAnimation.Texture = textureName;

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
                _textureGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Texture, ReturnAnimation.Texture,Vector2.Zero, DrawnType.Animation));
                DrawnRectangle frameRectangle = new DrawnRectangle
                {
                    Name = frameRectangleName,
                    PositionX = 0,
                    PositionY = 0,
                    Size = new Size(0, 0),
                    Thickness = 1,
                    Color = GameGraphics.ConvertSystemColorToXNA(System.Drawing.Color.Fuchsia)
                };
                _textureGame.gameGraphics.AddDrawable(frameRectangle);
                _textureGame.gameGraphics.AddToDrawList(new DrawParam(frameRectangleName, frameRectangleName,new Vector2(frameRectangle.PositionX, frameRectangle.PositionY), DrawnType.Shape));
                FrameAction frameAction = new FrameAction
                {
                    Name = ReturnAnimation.Texture,
                    Drawable = ReturnAnimation.Texture,
                    Value = 1
                };
                StatusAction statusAction = new StatusAction
                {
                    Name = ReturnAnimation.Texture,
                    Drawable = ReturnAnimation.Texture,
                    Value = AnimationStatus.Paused
                };
                LoopAction loopActon = new LoopAction
                {
                    Name = ReturnAnimation.Texture,
                    Drawable = ReturnAnimation.Texture,
                    Value = true
                };

                textureManager.ExecuteAction(statusAction);
                textureManager.ExecuteAction(frameAction);
                textureManager.ExecuteAction(loopActon);
                SetAnimationTexture(textureName);
            };
            // This is here to prevent _textueGame from malfunctioning when tabbing through text fields. Not sure why, probably should look at that later.
            SendKeys.Send("{TAB}");
            // TODO: Make actions to loop texture, will need to do so for setting a new texture.
            

             _textureGame.Run();
            //Task task = Task.Run( () =>{_textureGame.Run();});
            

        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            if (_textureGame != null && _textureGame.IsActive)
            {
                _textureGame.CloseGame();    
            }
            if (_frameGame != null && _frameGame.IsActive)
            {
                _frameGame.CloseGame();
            }
        }

        private void SetAnimationFieldsToDefault()
        {
            txtBox_Scale.Text = "0";
            txtBox_Depth.Text = "0";
            txtBox_Speed.Text = "0";
        }
        private void listBox_Frames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_frameGameLoaded)
            {
                LoadFrameGame();
            }
            _frameGame.gameGraphics.ClearDrawList();
            if (listBox_Frames.SelectedItem == null)
            {
                btn_SetFrame.Enabled = false;
                return;
            }
            btn_SetFrame.Enabled = true;
            int selectedFrame = (int)listBox_Frames.SelectedItem;
            SetFieldsFromFrame(ReturnAnimation.Frames[selectedFrame]);
            lbl_FrameNumber.Text = selectedFrame.ToString();
            float width = ReturnAnimation.Frames[selectedFrame].TextureSource.Width;
            float height = ReturnAnimation.Frames[selectedFrame].TextureSource.Height;
            Vector2 position = Vector2.Zero;
            if (width <= panel_FrameDisplay.Width || height <= panel_FrameDisplay.Height)
            {
                Vector2 center = GetCenter(new Vector2(((width)*ReturnAnimation.Scale),(height)*ReturnAnimation.Scale));
                position = GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
            }
            if (!_frameGame.gameGraphics.DoesDrawableExist(ReturnAnimation.Name))
            {
                _frameGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name, position, DrawnType.Animation));    
            }
            else
            {
                _frameGame.gameGraphics.UpdateDrawPosition(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name,position, DrawnType.Animation));
            }
            Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
            drawAnimation.Frame = selectedFrame;
            _frameGame.gameGraphics.SetLoadedDrawn(drawAnimation);
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
            SetFrameData();

            animationManager.ExecuteAction(statusAction);
            animationManager.ExecuteAction(frameAction);
            animationManager.ExecuteAction(loopActon);
            _frameGame.gameForm.Focus();
        }

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
                Vector2 center = GetCenter(new Vector2(((ReturnAnimation.Frames[1].TextureSource.Width) * ReturnAnimation.Scale), (ReturnAnimation.Frames[1].TextureSource.Height) * ReturnAnimation.Scale));
                position = GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
            }
            _frameGame.gameGraphics.AddDrawable(ReturnAnimation);
            _frameGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name, position,DrawnType.Animation));
            _frameGame.Run();
        }

        private void btn_AddFrame_Click(object sender, EventArgs e)
        {
            AddFrame(new Frame(new GameRectangle(0,0,1,1)));
            if (!_frameGameLoaded)
            {
                LoadFrameGame();
            }
        }

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
            lbl_CurrentFrameCount.Text = ReturnAnimation.FrameCount.ToString();
            return ReturnAnimation.RemoveFrame(frame);
        }

        private void SetFieldsFromFrame(Frame frame)
        {
            txtBox_FrameX.Text = frame.TextureSource.X.ToString();
            txtBox_FrameY.Text = frame.TextureSource.Y.ToString();
            txtBox_FrameWidth.Text = frame.TextureSource.Width.ToString();
            txtBox_FrameHeight.Text = frame.TextureSource.Height.ToString();
        }

        private delegate void SetTextCallBack(string text);
        private void SetAnimationTexture(string textureName)
        {
            _textureGame.gameGraphics.AddToDrawList(new DrawParam(textureName, textureName, new Vector2(0, 0), DrawnType.Animation));
            if (lbl_TextureName.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetAnimationTexture);
                this.BeginInvoke(d, new object[] {textureName});
            }
            else
            {
                lbl_TextureName.Text = textureName;    
            }
        }

        private void SetAnimationFields(Animation animation)
        {
            txtBox_AnimationName.Text = animation.Name;
            txtBox_Depth.Text = animation.Depth.ToString();
            txtBox_Scale.Text = animation.Scale.ToString();
            txtBox_Speed.Text = animation.FramesPerSecond.ToString();
            if (animation.FrameCount > 0)
            {
                for (int i = 1; 1 <= animation.FrameCount; i++)
                {
                    listBox_Frames.Items.Add(i);
                }
            }
        }

        private void btn_SetFrame_Click(object sender, EventArgs e)
        {
            SetFrameData();
        }
        private Vector2 GetCenter(Vector2 box)
        {
            return new Vector2(box.X / 2, box.Y / 2);
        }

        private Vector2 GetDrawPosition(Vector2 boxLimits, Vector2 center)
        {
            return new Vector2((boxLimits.X / 2) - center.X, (boxLimits.Y / 2) - center.Y);
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            BinaryTexture texture = _binaryTextures.FirstOrDefault(t => t.Name == ReturnAnimation.Texture);
            if (texture == null)
            {
                MessageBox.Show("Invalid texutre", "Invalid Texture", MessageBoxButtons.OK);
                return;
            }
            PreviewAnimationWindow previewAnimation = new PreviewAnimationWindow(ReturnAnimation, texture);
            previewAnimation.ShowDialog();
        }

        private void btn_RemoveFrame_Click(object sender, EventArgs e)
        {
            if (listBox_Frames.SelectedItem == null) return;
            int selectedItem = Int32.Parse(listBox_Frames.SelectedItem.ToString());
            RemoveFrame(selectedItem);
            if (!_frameGameLoaded)
            {
                LoadFrameGame();
            }
        }

        private void btn_SetAnimation_Click(object sender, EventArgs e)
        {
            ReturnAnimation.Scale = float.Parse(txtBox_Scale.Text);
            ReturnAnimation.Depth = float.Parse(txtBox_Depth.Text);
            ReturnAnimation.FramesPerSecond = Int32.Parse(txtBox_Speed.Text);
            Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
            drawAnimation.Scale = float.Parse(txtBox_Scale.Text);
            drawAnimation.Depth = float.Parse(txtBox_Depth.Text);
            drawAnimation.FramesPerSecond = Int32.Parse(txtBox_Speed.Text);
            _frameGame.gameGraphics.SetLoadedDrawn(drawAnimation);
        }

        private void btn_SetSpriteSheet_Click(object sender, EventArgs e)
        {

        }

        private void SetFrameData()
        {
            int x = Int32.Parse(txtBox_FrameX.Text);
            int y = Int32.Parse(txtBox_FrameY.Text);
            int width = Int32.Parse(txtBox_FrameWidth.Text);
            int height = Int32.Parse(txtBox_FrameHeight.Text);
            int frame = Int32.Parse(lbl_FrameNumber.Text);
            Frame setFrame = new Frame(new GameRectangle(x, y, width, height));
            ReturnAnimation.SetFrame(frame, setFrame);
            Vector2 position = Vector2.Zero;
            if (width <= panel_FrameDisplay.Width || height <= panel_FrameDisplay.Height)
            {
                Vector2 center = GetCenter(new Vector2(((width) * ReturnAnimation.Scale), (height) * ReturnAnimation.Scale));
                position = GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
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
                Name = frameRectangleName,
                Drawable = frameRectangleName,
                Value = height
            };
            RectangleWidthAction rectangleWidthAction = new RectangleWidthAction
            {
                Name = frameRectangleName,
                Drawable = frameRectangleName,
                Value = width
            };
            PositionXAction rectanglePositionXAction = new PositionXAction
            {
                Name = frameRectangleName,
                Drawable = frameRectangleName,
                Value = x
            };
            PositionYAction rectanglePositionYAction = new PositionYAction
            {
                Name = frameRectangleName,
                Drawable = frameRectangleName,
                Value = y
            };



            textureManager.ExecuteAction(rectanglePositionXAction);
            textureManager.ExecuteAction(rectanglePositionYAction);
            textureManager.ExecuteAction(rectangleWidthAction);
            textureManager.ExecuteAction(rectangleHeightAction);
            _textureGame.RunOneFrame();
        }

        private void btn_TestFrame_Click(object sender, EventArgs e)
        {

        }

    }
}
