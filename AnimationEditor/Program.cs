using System;
using System.ComponentModel;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;
using AnimationEditor.GameClasses;
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
                mainWindow.Game = new TextureGame(mainWindow.picBox_AnimationPreview.Handle, mainWindow, mainWindow.picBox_AnimationPreview, new Vector2(0, 0));
                mainWindow.Game.Run();
            }
        }
    }
#endif
}
