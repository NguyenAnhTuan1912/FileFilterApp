using FileFilter.Helpers;
using FileFilter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileFilter.DTO;
using System.IO;
using FileFilter.Utilities;

namespace FileFilter.BLL
{
    public class FileBLL
    {
        private static FileDAL _fileDAL = new FileDAL();

        public string sourcePath { get; set; }
        public string destinationPath { get; set; }
        public string[] fileNames { get; set; } = null;
        public string[] filePaths { get; set; } = null;
        public string generalFileName { get; set; }
        public string typeOfFiles { get; set; } = "JPG|jpg|JPEG|jpeg|PNG|png|RAW|raw";
        public string newFolderName { get; set; } = "New Folder";

        public static string ProjectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        private static FolderBrowserDialog _FolderBrowserDialog = new FolderBrowserDialog();
        private static object _Lock = new object();
        private static FileBLL _Instance = null;

        private FileBLL() { }

        public static FileBLL GetInstance()
        {
            if(_Instance == null)
            {
                lock(_Lock)
                {
                    if (_Instance == null)
                    {
                        _Instance = new FileBLL();
                    }
                }
            }
            return _Instance;
        }

        public static string ShowFolderBrowseDialog()
        {
            if (_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return _FolderBrowserDialog.SelectedPath;
            } else
            {
                return "";
            }
        }

        public int getNumberOfExistedFiles(string[] fullPathFile)
        {
            int number = 0;
            foreach(string path in fullPathFile)
            {
                if (_fileDAL.isFileExist(path)) number += 1;
            }
            return number;
        }

        public string[] readInTextFile(string fullFilePath)
        {
            return _fileDAL.readFile(fullFilePath);
        }

        public bool isDirectoryExist(string fullFolderPath)
        {
            try
            {
                return _fileDAL.isDirectoryExist(fullFolderPath);
            } catch(Exception ex)
            {
                MessageBoxUtility.ShowError(ex.Message);
                return false;
            }
        }

        public List<FileInfo> getAllFilesInfo(string fullFolderPath, string generalFilename, string extension)
        {
            try
            {
                if (!ValidatorUtility.ValidateFullFolderPath(fullFolderPath)) return null;

                List<FileInfo> files = _fileDAL.getAllFilesInfo(fullFolderPath, generalFilename, extension);
                if (files == null) return null;
                return files;
            } catch(Exception ex)
            {
                return null;
            }
        }

        public List<FileInfo> getAllFilesInfo(string fullFolderPath, string[] fileNames)
        {
            if (!ValidatorUtility.ValidateFullFolderPath(fullFolderPath)) return null;
            List<FileInfo> files = new List<FileInfo>();
            return files;
        }

        public void reset()
        {
            sourcePath = "";
            destinationPath = "";
            fileNames = null;
            generalFileName = "";
            typeOfFiles = "JPG/JPEG/PNG/RAW";
            newFolderName = "New Folder";
        }
    }
}
