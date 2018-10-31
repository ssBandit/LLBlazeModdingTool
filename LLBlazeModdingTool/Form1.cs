using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LLBlazeModdingTool
{
    public partial class Form1 : Form
    {
        string[] filenames;
        string gameDir = AppDomain.CurrentDomain.BaseDirectory;

        public Form1()
        {
            InitializeComponent();

            if (gameDir == null || gameDir == "" || !gameDir.EndsWith("characters\\"))
            {
                MessageBox.Show("Place the file along with UnityEX.exe in your \"steam/SteamApps/common/LLBlaze/Bundles/characters\" folder", "Invalid game directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openTextureButton_Click(object sender, EventArgs e)
        {
            skinListBox.Items.Clear();
            //Opens the file and saves it in ram
            openFileDialog1.ShowDialog();
        }

        private void importInGameButton_Click(object sender, EventArgs e)
        {
            //Exports the archive (unityEX export "S:\SteamGAEMS\SteamApps\common\LLBlaze\Bundles\characters\mainmodels" -t tex)
            //Create the textures folder and put the file in there renaming it to an appropriate filename
            //Repack the archive

            if (filenames == null || filenames[0] == "")
            {
                MessageBox.Show("Wrong texture file", "Texture file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string file in filenames)
                {
                    UnityEXController.PlaceFile(gameDir, file, skinListBox.SelectedItem.ToString());
                }
                UnityEXController.ZipArchive(gameDir);
                Thread.Sleep(5000);
                MessageBox.Show("Completed successfully, your skin(s) are now in the game \n ...probably, this message doesn't know shit, it's just for show", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filenames = openFileDialog1.FileNames;
            if(filenames.Length == 1)
            {
                updateList(filenames[0]);
            }
            else
            {
                skinListBox.Items.Add("Auto");
            }
        }

        private void updateList(string filename)
        {
            skinListBox.Items.Add("Auto");

            string character = filename.Split('\\').Last().Split('T')[0];
            List<string> skins = new List<string>();

            switch (character)
            {
                case "boom":
                    var l = new List<string>(){"boomTex.tex", "boomTex_Alt00.tex", "boomTex_Alt01.tex", "boomTex_Alt02.tex", "boomTex_Alt03.tex", "boomTex_Alt04.tex", "boomTex_Alt05.tex", "boomTex_Alt06.tex", "boomTex_Alt07.tex", "boomTex_Alt08.tex", "boomTex_Alt09.tex", "boomTex_Alt10.tex", "boomTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "boomZoot":
                    l = new List<string>() {"boomZootTex.tex", "boomZoot2Tex.tex", "boomZootTex_Corpse.tex"};
                    skins.AddRange(l);
                    break;
                case "boss":
                    l = new List<string>() { "bossTex.tex", "bossTex_Alt00.tex", "bossTex_Alt01.tex", "bossTex_Alt02.tex", "bossTex_Alt03.tex", "bossTex_Alt04.tex", "bossTex_Alt05.tex", "bossTex_Alt06.tex", "bossTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "bossOmega":
                    l = new List<string>() { "bossOmegaTex.tex", "bossOmega2Tex.tex", "bossOmegaTex_Corpse.tex"};
                    skins.AddRange(l);
                    break;
                case "candy":
                    l = new List<string>() { "candyTex.tex", "candyTex_Alt00.tex", "candyTex_Alt01.tex", "candyTex_Alt02.tex", "candyTex_Alt03.tex", "candyTex_Alt04.tex", "candyTex_Alt05.tex", "candyTex_Alt06.tex", "candyTex_Alt07.tex", "candyTex_Alt08.tex", "candyTex_Alt09.tex", "candyTex_Alt10.tex", "candyTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "candyStrait":
                    l = new List<string>() { "candyStraitTex.tex", "candyStrait2Tex.tex", "candyStraitTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "cop":
                    l = new List<string>() { "copTex.tex", "copTex_Alt00.tex", "copTex_Alt01.tex", "copTex_Alt02.tex", "copTex_Alt03.tex", "copTex_Alt04.tex", "copTex_Alt05.tex", "copTex_Alt06.tex", "copTex_Alt07.tex", "copTex_Alt08.tex", "copsTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "croc":
                    l = new List<string>() { "crocTex.tex", "crocTex_Alt00.tex", "crocTex_Alt01.tex", "crocTex_Alt02.tex", "crocTex_Alt03.tex", "crocTex_Alt04.tex", "crocTex_Alt05.tex", "crocTex_Alt06.tex", "crocTex_Alt07.tex", "crocTex_Alt08.tex", "crocTex_Alt09.tex", "crocsTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "crocMecha":
                    l = new List<string>() { "crocMechaTex.tex", "crocMecha2Tex.tex", "candyStraitTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "dice":
                    l = new List<string>() { "diceTex.tex", "diceTex_Alt00.tex", "diceTex_Alt01.tex", "diceTex_Alt02.tex", "diceTex_Alt03.tex", "diceTex_Alt04.tex", "diceTex_Alt05.tex", "diceTex_Alt06.tex", "dicesTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "PongSchool":
                    l = new List<string>() { "PongSchoolTex.tex", "PongSchool2Tex.tex", "PongSchoolTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "electro":
                    l = new List<string>() { "electroTex.tex", "electroTex_Alt00.tex", "electroTex_Alt01.tex", "electroTex_Alt02.tex", "electroTex_Alt03.tex", "electroTex_Alt04.tex", "electroTex_Alt05.tex", "electroTex_Alt06.tex", "electrosTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "kid":
                    l = new List<string>() { "kidTex.tex", "kidTex_Alt00.tex", "kidTex_Alt01.tex", "kidTex_Alt02.tex", "kidTex_Alt03.tex", "kidTex_Alt04.tex", "kidTex_Alt05.tex", "kidTex_Alt06.tex", "kidTex_Alt07.tex", "kidTex_Alt08.tex", "kidTex_Alt09.tex", "kidTex_Alt10.tex", "kidTex_Alt11.tex", "kidsTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "kidMascot":
                    l = new List<string>() { "kidMascotTex.tex", "kidMascot2Tex.tex", "kidMascotTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "robot":
                    l = new List<string>() { "robotTex.tex", "robotTex_Alt00.tex", "robotTex_Alt01.tex", "robotTex_Alt02.tex", "robotTex_Alt03.tex", "robotTex_Alt04.tex", "robotTex_Alt05.tex", "robotTex_Alt06.tex", "robotTex_Alt07.tex", "robotTex_Alt08.tex", "robotTex_Alt09.tex", "robotTex_Alt10.tex", "robotsTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "RobotSkeleton":
                    l = new List<string>() { "RobotSkeletonTex.tex", "RobotSkeleton2Tex.tex", "RobotSkeletonTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                case "skate":
                    l = new List<string>() { "skateTex.tex", "skateTex_Alt00.tex", "skateTex_Alt01.tex", "skateTex_Alt02.tex", "skateTex_Alt03.tex", "skateTex_Alt04.tex", "skateTex_Alt05.tex", "skateTex_Alt06.tex", "skatesTex_Corpse.tex" };
                    skins.AddRange(l);
                    break;
                default:
                    l = new List<string>() {"wrong file name", "any complaints - @Bandit with your issue" };
                    skins.AddRange(l);
                    break;
            }

            foreach (var skin in skins)
            {
                skinListBox.Items.Add(skin);
            }


        }

        private void unzipButton_Click(object sender, EventArgs e)
        {
            UnityEXController.UnzipArchive(gameDir);
            openTextureButton.Enabled = true;
        }

        private void skinListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            importInGameButton.Enabled = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            string info = "How to use:\n" +
                " 1. Place this program and unityEX.exe inside your steam/SteamApps/common/LLBlaze/Bundles/characters folder\n" +
                " 2.Run the program (make a backup of mainmodels file, but the program does it for you just in case)\n" +
                " 3. Unpack the archive\n 4. Select one or multiple skin files you want to replace (name them accordingly if there are multiple)\n" +
                " 5. Select which skin file to replace or leave it at Auto to determine base on filename\n" +
                " 6. Select Import in game and after some time a confirmation message will pop up informing you that operation is done (probably) " +
                "\n\nMade by Bandit#1665 using UnityEx by DragonZH\n" +
                "Might add skin preview and other fancy stuff if I figure it out";
            MessageBox.Show(info, "Info and credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
