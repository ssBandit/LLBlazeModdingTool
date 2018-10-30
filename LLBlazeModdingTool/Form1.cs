using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLBlazeModdingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openTextureButton_Click(object sender, EventArgs e)
        {
            //Opens the file and saves it in ram
            openFileDialog1.ShowDialog();
        }

        private void importInGameButton_Click(object sender, EventArgs e)
        {
            //Exports the archive (unityEX export "S:\SteamGAEMS\SteamApps\common\LLBlaze\Bundles\characters\mainmodels" -t tex)
            //Create the textures folder and put the file in there renaming it to an appropriate filename
            //Repack the archive
        }

        private void selectDirButton_Click(object sender, EventArgs e)
        {
            //Show dialog asking the game directory and save it to a file
            folderBrowserDialog1.ShowDialog();
        }
    }
}
