using System.IO;

namespace MusicPlayer.viewmodel.util
{
    public class FileUtil
    {
        private static readonly string MainDir = @"C:\Users\Speedyservice\Music\MusicPlayer";


        public static string GetFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }


        public static void CopyPasteFileToMainDir(string sourceFilePath)
        {
            string destFilePath = MainDir + @"\" + Path.GetFileName(sourceFilePath);
            File.Copy(sourceFilePath, destFilePath, true);
        }


        public static bool CheckIfFileExistInMainDir(string filePath)
        {
            return Path.GetDirectoryName(filePath) == MainDir;
        }
    }
}
