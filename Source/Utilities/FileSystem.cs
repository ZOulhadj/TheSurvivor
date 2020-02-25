using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSurvivor.Source.Utilities
{
    class FileSystem
    {
        public static string GetAsset(string relativePath)
        {
            return Path.GetFullPath("..\\..\\Assets\\" + relativePath);
        }
    }
}
