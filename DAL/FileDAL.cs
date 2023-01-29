using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter.DAL
{
    public class FileDAL
    {
        public FileDAL() {
        }

        // Ohter methods
        public void createDirectory(string directoryName, string directorySourcePath = "")
        {

        }

        public bool isDirectoryExist(string fullFolderPath)
        {
            bool check = Directory.Exists(fullFolderPath);
            if (!check) throw new Exception("Thư mục không tồn tại!");
            return check;
            return false;
        }

        public bool isFileExist(string fullFilePath)
        {
            DirectoryInfo di = new DirectoryInfo(fullFilePath);
            bool check = File.Exists(fullFilePath);
            if (!check) throw new Exception("File không tồn tại!");
            return check;
        }

        public void moveFile()
        {

        }

        public void copyFile()
        {

        }

        public void deleteFile()
        {
            
        }

        public List<string> getFullFilePaths(string fullFolderPath, string generalFileName, string extension)
        {
            Regex generalFileNamePatternRegex = new Regex(String.Format("^([^\\/\\\\:*?\\\"<>|\\.]*)({0})([^\\/\\\\:*?\\\"<>|\\.]*)\\.({1})$", generalFileName, extension));
            List<string> foundFullFilePaths = Directory
                .EnumerateFiles(fullFolderPath, String.Format("{0}*.*", generalFileName))
                .Where(file =>
                    generalFileNamePatternRegex.IsMatch(Path.GetFileName(file))
                )
                .ToList();
            return foundFullFilePaths;
        }

        public List<FileInfo> getAllFilesInfo(string fullFolderPath, string generalFileName, string extension)
        {
            Regex generalFileNamePatternRegex = new Regex(String.Format("^([^\\/\\\\:*?\\\"<>|\\.]*)({0})([^\\/\\\\:*?\\\"<>|\\.]*)\\.({1})$", generalFileName, extension));
            DirectoryInfo di = new DirectoryInfo(fullFolderPath);
            List<FileInfo> files = di
                //.GetFiles(String.Format("{0}*.*", generalFileName))
                .EnumerateFiles(String.Format("{0}*.*", generalFileName))
                .Where(file =>
                    generalFileNamePatternRegex.IsMatch(Path.GetFileName(file.Name))
                )
                .ToList();
            return files;
        }

        public List<FileInfo> getAllFilesInfo(string fullFolderPath, string[] fileNames, string extension)
        {
            List<FileInfo> files = new List<FileInfo>();
            return files;
        }

        public string[] readFile(string fullFilePath)
        {
            return File.ReadLines(fullFilePath).ToArray();
        }
    }
}
