using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.IO
{
    public class PreSignReady
    {
        public static void SignReady(string apkPath)
        {
            string zipPath;
            zipPath = Path.ChangeExtension(apkPath, ".zip");
            File.Move(apkPath, zipPath);
            using (ZipFile zipFile = ZipFile.Read(zipPath))
            {
                bool folderExists = zipFile.Any(entry => entry.FileName.Contains("META-INF"));
                if (folderExists)
                    zipFile.RemoveSelectedEntries("META-INF/");
                zipFile.Save();
            }
            apkPath = Path.ChangeExtension(zipPath, ".apk");
            File.Move(zipPath, apkPath);
        }
    }
}