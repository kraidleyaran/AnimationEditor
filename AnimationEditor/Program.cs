using System;
using System.ComponentModel;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;
using AnimationEditor.GameClasses;
using GraphicsManagerLib;
using Microsoft.Xna.Framework;

namespace AnimationEditor
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (MainWindow mainWindow = new MainWindow())
            {
                mainWindow.Show();
                mainWindow.Game = new AnimationGame(mainWindow.picBox_AnimationPreview.Handle, mainWindow, mainWindow.picBox_AnimationPreview, new Vector2(0, 0));
                mainWindow.Game.gameGraphics.GraphicsManager.DeviceCreated += delegate(object sender, EventArgs args)
                {
                    mainWindow.graphicsManager = new GraphicsManager(mainWindow.Game.gameGraphics);
                };
                mainWindow.Game.Run();
            }
        }
    }
#endif
}
