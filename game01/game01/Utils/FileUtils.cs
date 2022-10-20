using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game01.Utils
{
    internal class FileUtils
    {
        public static string PathProject => Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\net6.0", "");
        public static void SaveFile(string text, string path, string fileName)
        {
            var completedPath = Path.Combine(PathProject, path);
            if (!Directory.Exists(completedPath))
            {
                Directory.CreateDirectory(completedPath);
            }

            var filePath = Path.Combine(completedPath, fileName);

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            File.WriteAllText(filePath, text);
        }

        internal static string GetText(string path, string file)
        {
            var completedPath = Path.Combine(PathProject, path, file);

            if (!File.Exists(completedPath))
            {
                return String.Empty;
            }

            return File.ReadAllText(completedPath);
        }
    }
}
