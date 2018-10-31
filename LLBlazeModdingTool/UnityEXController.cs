using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LLBlazeModdingTool
{
    class UnityEXController
    {

        public static void UnzipArchive(string gameDir)
        {
            string strCmdText = $"unityEX export \"{gameDir}mainmodels\" -t tex";
            System.Diagnostics.Process.Start("CMD.exe", "/c" + strCmdText);
            
            /*if (!File.Exists($"{gameDir}backup\\mainmodels"))
            {
                Directory.CreateDirectory($"{gameDir}\\backup");
                File.Copy($"{gameDir}mainmodels", $"{gameDir}\\backup\\mainmodels", false);
            }*/
        }

        public static void PlaceFile(string gameDir, string fileName, string replaceSkinName)
        {
            
            string fileDir = fileName;

            Directory.CreateDirectory($"{gameDir}Unity_Assets_Files\\mainmodels\\CAB-dbf0219a1c0b2d3deb38d1e07f854ad1\\Textures");
            string destinationFileName = "";

            //Replace this with filename from list
            if (replaceSkinName == "Auto")
            {
                fileName = fileName.Split('\\').Last<string>();
                destinationFileName = $"{gameDir}Unity_Assets_Files\\mainmodels\\CAB-dbf0219a1c0b2d3deb38d1e07f854ad1\\Textures\\{fileName}";
            }
            else
            {
                destinationFileName = $"{gameDir}Unity_Assets_Files\\mainmodels\\CAB-dbf0219a1c0b2d3deb38d1e07f854ad1\\Textures\\{replaceSkinName}.dds";
            }



            File.Copy(fileDir, destinationFileName, true);
        }

        public static void ZipArchive(string gameDir)
        {
            string strCmdText = $"cd {gameDir} & {gameDir}unityEX.exe import \"{gameDir}mainmodels\"";
            System.Diagnostics.Process.Start("CMD.exe", "/c" + strCmdText);
        }
    }
}
