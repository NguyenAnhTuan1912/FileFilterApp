using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter.DAL
{
    internal class FileDAL
    {
        private string _sourcePath;
        private string _destinationPath;

        private static object _lock = new object();
        private static FolderBrowserDialog _folderBrowserDialog = new FolderBrowserDialog();

        public static FileDAL instance = null;

        private FileDAL(string sourcePath) {
            _sourcePath = sourcePath;
        }

        public static FileDAL GetInstance(string sourcePath = "")
        {
            if (instance == null)
            {
                lock(_lock)
                {
                    if (instance == null)
                    {
                        instance = new FileDAL(sourcePath);
                    }
                }
            }
            return instance;
        }

        // Ohter methods
        public void CreateDirectory(string directoryName, string directorySourcePath = "")
        {

        }

        public bool CheckFile()
        {
            return true;
        }

        public void MoveFile()
        {

        }

        public void CopyFile()
        {

        }

        public void DeleteFile()
        {
            
        }

        public string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }

        // Getter and Setter methods
        public FolderBrowserDialog GetFolderBrowseDialog()
        {
            return _folderBrowserDialog;
        }

        public string getSourcePath()
        {
            return _sourcePath;
        }

        public void setSourcePath(string sourcePath)
        {
            _sourcePath = sourcePath;
        }

        public string getDestinationPath()
        {
            return _destinationPath;
        }

        public void setDestinationPath(string destinationPath)
        {
            _destinationPath = destinationPath;
        }
    }
}
