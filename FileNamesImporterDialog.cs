using FileFilter.BLL;
using FileFilter.BLL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter
{
    public partial class FileNamesImporterDialog : Form
    {
        private FormHelper _formHelper;
        private FileBLL _fileBLL;
        public string[] lines = {};

        public FileNamesImporterDialog()
        {
            InitializeComponent();
            _formHelper = new FormHelper();
            _fileBLL = new FileBLL();
            this.FormClosed += new FormClosedEventHandler(FileNamesImporterDialog_FormClosed);
            this.rtbFileNames.AllowDrop = true;
        }

        private void FileNamesImporterDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeForm();
        }

        private void closeForm()
        {
            _formHelper = null;
            this.Close();
        }

        private void btnCheckFile_Click(object sender, EventArgs e)
        {
            this.lines = _formHelper.getAllLinesFromRTB(rtbFileNames);
            string userFilenamesOutputColor = this.lines.Length == 1 && this.lines[0] == "" ? "Red" : "Green";
            
            _formHelper.clearOutputBox(rtbOutput);
            _formHelper.printOutput(rtbOutput, new List<string>
            {
                "Bạn nhập: ",
                String.Format("[{0}]| {1} file name(s).", userFilenamesOutputColor, this.lines.Length),
                "\n",
                "Hệ thống tìm được: ",
                "[Red]|0 file(s)."
            });
            _formHelper.appendTextToOutputBox(rtbOutput, "\n\n");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(this.lines.Length == 0) this.lines = _formHelper.getAllLinesFromRTB(rtbFileNames);
            closeForm();
        }

        private void rtbFileNames_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
                // If dropped file is a txt file.
                if(data.Length == 1)
                {
                    string[] linesInTxtFile = _fileBLL.readInTextFile(data[0]);
                    rtbFileNames.Text = String.Join("\n", linesInTxtFile);
                }
                // If dropped files are multiple files.
                else
                {
                    rtbFileNames.Text = String.Join("\n", data.Select(line => Path.GetFileName(line)).ToArray());
                }
            }
        }
    }
}
