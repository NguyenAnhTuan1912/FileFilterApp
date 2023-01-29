using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FileFilter.Utilities
{
    public static class ValidatorUtility
    {
        private static Regex _NotAllowCharactersRegEx = new Regex("\\/:*?\\\"<>|");
        private static Regex _TextFileExtensionRegEx = new Regex(@"\.txt", RegexOptions.IgnoreCase);
        private static Regex _FileNamePatternRegEx = new Regex("^([^\\/\\\\:*?\\\"<>|\\.]+)\\.([a-zA-Z]+)$");
        private static Regex _FullFolderPathPatternRegEx = new Regex("^[A-Z]:\\\\([^\\/:*?\"<>|]+\\\\)+([^\\/:*?\"<>|\\.]+)$");
        private static Regex _FullFilePathPatternRegEx = new Regex("^[A-Z]:\\\\([^\\/:*?\"<>|]+\\\\)+([^\\/:*?\"<>|]+)\\.([a-zA-Z]+)$");
        private static Regex _ImageFileExtensionsRegEx = new Regex("JPG|jpg|JPEG|jpeg|PNG|png|RAW|raw");
        private static Regex _DocumentFileExtensionsRegEx = new Regex("TXT|txt|PDF|pdf|DOC|doc|DOCX|docx");
        private static Regex _EscapeStringRegEx = new Regex(@"(\\r)|(\\t)|(\\n)|(\\b)");

        public static bool isImageFile(string fullFileName)
        {
            return _ImageFileExtensionsRegEx.IsMatch(Path.GetExtension(fullFileName).Substring(1));
        }

        public static bool isDocumentFile(string fullFileName)
        {
            return _DocumentFileExtensionsRegEx.IsMatch(Path.GetExtension(fullFileName).Substring(1));
        }

        public static bool isEscapeString(string text)
        {
            return _EscapeStringRegEx.IsMatch(text);
        }

        public static bool ValidateText(string text)
        {
            if (text == "") return false;
            return _NotAllowCharactersRegEx.IsMatch(text);
        }

        public static bool ValidateFullFilePath(string fullFilePath)
        {
            return _FullFilePathPatternRegEx.IsMatch(fullFilePath);
        }

        public static bool ValidateFullFolderPath(string fullFolderPath)
        {
            return _FullFolderPathPatternRegEx.IsMatch(fullFolderPath);
        }

        public static bool ValidateFileName(string fileName)
        {
            return _FileNamePatternRegEx.IsMatch(fileName);
        }

        public static bool ValidateFullPathOfTextFile(string fullFilePath)
        {
            if (fullFilePath == "") return false;
            if (!ValidateFullFilePath(fullFilePath)) return false;
            return _TextFileExtensionRegEx.IsMatch(Path.GetExtension(fullFilePath));
        }

        public static bool ValidateFileNameOfTextFile(string fileName)
        {
            if (fileName == "") return false;
            if (!ValidateFileName(fileName)) return false;
            return _TextFileExtensionRegEx.IsMatch(Path.GetExtension(fileName));
        }
    }
}
