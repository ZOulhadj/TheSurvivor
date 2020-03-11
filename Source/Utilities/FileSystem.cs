using System.IO;

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
