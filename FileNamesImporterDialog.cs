using FileFilter.BLL;
using FileFilter.Helpers;
using FileFilter.Utilities;
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
        public string[] lines = { };
        public int numberOfExistedFiles = 0;

        public FileNamesImporterDialog()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.FormClosed += new FormClosedEventHandler(FileNamesImporterDialog_FormClosed);
            this.rtbFileNames.AllowDrop = true;

            _formHelper = new FormHelper();
            _fileBLL = FileBLL.GetInstance();
        }

        private void FileNamesImporterDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeForm();
        }

        private void closeForm()
        {
            _fileBLL = null;
            _formHelper = null;
            lines = null;
            this.Dispose();
            this.Close();
        }

        /*
        private void btnCheckFile_Click(object sender, EventArgs e)
        {
            try {
                string userFilenamesOutputColor = this.lines.Length == 1 && this.lines[0] == "" ? "Red" : "Green";
                string textResultOfNumberOfExistedFilesAfterCheck = "[Green]|" + numberOfExistedFiles + " file(s).";

                this.lines = _formHelper.getAllLinesFromRTB(rtbFileNames);
                this.numberOfExistedFiles = _fileBLL.getNumberOfExistedFiles(this.lines);

                if(numberOfExistedFiles == 0)
                {
                    textResultOfNumberOfExistedFilesAfterCheck = "[Red]|" + numberOfExistedFiles + " file(s).";
                }

                _formHelper.clearOutputBox(rtbOutput);
                _formHelper.writeLinesToRichTextBox(rtbOutput, new List<string>
                {
                    "Bạn nhập: ",
                    String.Format("[{0}]| {1} name(s).", userFilenamesOutputColor, this.lines.Length),
                    "\n",
                    "Hệ thống tìm được: ",
                    textResultOfNumberOfExistedFilesAfterCheck,
                    "\n",
                    "Không tìm thấy: ",
                    String.Format("[Red]| {0} file(s).", this.lines.Length - numberOfExistedFiles)
                });
                _formHelper.appendTextToOutputBox(rtbOutput, "\n\n");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(this.lines.Length == 0) this.lines = _formHelper.getAllLinesFromRTB(rtbFileNames);
            _fileBLL.fileNames = lines;
            closeForm();
        }

        private void rtbFileNames_DragDrop(object sender, DragEventArgs e)
        {
            // MessageBox.Show(e.Data.GetData(DataFormats.FileDrop).GetType().ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] pathToFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (pathToFiles.Length == 1)
                {
                    string pathToFile = pathToFiles[0];
                    string[] linesInTxtFile = _fileBLL.readInTextFile(pathToFile);
                    if(!ValidatorUtility.ValidateFullPathOfTextFile(pathToFile))
                    {
                        MessageBoxUtility.ShowError("Chỉ nhận file text thôi :(", "Đã có lỗi xảy ra");
                        return;
                    }
                    // rtbOutput.Text = pathToFile;
                    rtbFileNames.Text = String.Join("\n", linesInTxtFile);
                }
                else
                {
                    MessageBoxUtility.ShowInfo("Tính này này sẽ được thêm sau!", "Thông báo");
                }
            }
        }
    }
}
