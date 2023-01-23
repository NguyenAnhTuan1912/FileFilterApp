using FileFilter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter.BLL
{
    public class FileBLL
    {
        private static FileDAL _fileDAL = FileDAL.GetInstance();

        public string getSelectedPathFromFBD()
        {
            if (_fileDAL.GetFolderBrowseDialog().ShowDialog() == DialogResult.OK)
            {
                return _fileDAL.GetFolderBrowseDialog().SelectedPath;
            } else
            {
                return "";
            }
        }
    }
}
