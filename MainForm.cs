using FileFilter.BLL;
using FileFilter.BLL.Extensions;
using FileFilter.BLL.Helpers;
using FileFilter.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter
{
    public partial class FileFilterForm : Form
    {
        private FileBLL _fileBll = new FileBLL();
        private FormHelper _formHelper;
        private string _projectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        private string[] _appInformationRTBOutputTemplate = null;
        private string[] _checkInputRTBOutputTemplate = null;

        public FileFilterForm()
        {
            InitializeComponent();
            _formHelper = new FormHelper();

            Init();
        }

        public void Init()
        {
            radGeneralFileName.Checked = true;
            ckbSaveToNewFolder.Checked = true;
            ckbSeparateFiles.Checked = true;
            cbxTypeOfFile.DataSource = cbxTypeOfFile.Items;
        }
        ///////////////////////////
        // Begin radio button events
        private void radGeneralFileName_CheckedChanged(object sender, EventArgs e)
        {
            if(radGeneralFileName.Checked)
            {
                txtGeneralFileName.Enabled = true;
                btnOpenMultipleFileNameImportingForm.Enabled = false;
            }
        }

        private void radMultipleFileNameImportingForm_CheckedChanged(object sender, EventArgs e)
        {
            if(radMultipleFileNameImportingForm.Checked)
            {
                txtGeneralFileName.Enabled = false;
                btnOpenMultipleFileNameImportingForm.Enabled = true;
            }
        }

        private void ckbSaveToNewFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSaveToNewFolder.Checked)
            {
                txtNewFolderName.Enabled = true;
            } else
            {
                txtNewFolderName.Enabled = false;
            }
        }
        // End radio button event

        ///////////////////////////
        // Begin text events
        private void txtGeneralFileName_TextChanged(object sender, EventArgs e)
        {
            txtNewFolderName.Text = txtGeneralFileName.Text.Trim();
        }
        // End text events

        ///////////////////////////
        // Begin button events
        private void btnOpenSourceFB_Click(object sender, EventArgs e)
        {
            txtSourcePath.Text = _fileBll.getSelectedPathFromFBD();
        }

        private void btnOpenDestinationFB_Click(object sender, EventArgs e)
        {
            txtDestinationPath.Text = _fileBll.getSelectedPathFromFBD();
        }

        private void btnCheckBeforeRun_Click(object sender, EventArgs e)
        {
            string typeOfFileOutputText = cbxTypeOfFile.SelectedIndex == 0 ? "File ảnh (JPG/JPEG/PNG/RAW)" : "File tài liệu (TXT/PDF/DOC/DOCX)";
            string fileNameOptionOutputText = radGeneralFileName.Checked ? " Tên chung cho nhiều files - " + txtGeneralFileName.Text : "Nhiều tên files";
            string newFolderNameOptionOutputText = ckbSaveToNewFolder.Checked ? txtNewFolderName.Text : "Không";
            string newFolderNameOptionOutputColor = ckbSaveToNewFolder.Checked ? "Green" : "Red";
            string separateFilesOptionOutputText = ckbSeparateFiles.Checked ? "Có" : "Không";
            string separateFilesOptionOutputColor = ckbSeparateFiles.Checked ? "Green" : "Red";
            int foundFileOutputText = 0;
            _formHelper.clearOutputBox(rtbOutput);

            _formHelper.printOutput(rtbOutput, new List<string>
            {
                "Đường dẫn tới thư mục nguồn: ",
                String.Format("[Green]|{0}", txtSourcePath.Text),
                "\n",
                "Đường dẫn tới thư mục đích: ",
                String.Format("[Green]|{0}", txtDestinationPath.Text),
                "\n",
                "Loại file: ",
                String.Format("[Green]|{0}", typeOfFileOutputText),
                "\n",
                "Bạn chọn: ",
                String.Format("[Green]|{0}", fileNameOptionOutputText),
                "\n",
                "Lưu trong thư mục mới (thư mục con của thư mục đích): ",
                String.Format("[{0}]|{1}", newFolderNameOptionOutputColor, newFolderNameOptionOutputText),
                "\n",
                "Tách các files: ",
                String.Format("[{0}]|{1}", separateFilesOptionOutputColor, separateFilesOptionOutputText),
                "\n\n",
                "Đã tìm thấy: ",
                String.Format("[{0}]|{1} file(s).", foundFileOutputText == 0 ? "Red" : "Green", foundFileOutputText)
            });
        }

        private void btnOpenInformationForm_Click(object sender, EventArgs e)
        {
            _formHelper.clearOutputBox(rtbOutput);
            /*
            if (_appInformationRTBOutputTemplate is null)
            {
                string otherDir = Path.Combine(_projectDir, "Other");
                string appInformationRTBOutputTemplateDir = Path.Combine(otherDir, "AppInformationRTBOutputTemplate.txt");
                _appInformationRTBOutputTemplate = _fileBll.readTemplateInTextFile(appInformationRTBOutputTemplateDir);
            }
            _formHelper.printOutput(_appInformationRTBOutputTemplate.ToList());
            */
            _formHelper.printOutput(rtbOutput, new List<string>
            {
                "File Filter",
                "\n",
                "Phiên bản hiện tại: ",
                "[Green]|1.0.0",
                "\n",
                "Được viết bời: ",
                "[Green]|Nguyen Anh Tuan",
                "\n\n",
                "[Red]|Thông tin về File Filter",
                "\n---\n",
                "Là ứng dụng dùng để lọc file theo LOẠI của file. " +
                "Các bạn có thể dùng để lọc theo tên chung, hoặc lọc theo nhiều tên. " +
                "Ứng dụng này ban đầu được tạo ra dành cho các thợ chụp hình/người hay chụp ảnh/nhiếp ảnh gia " +
                "dùng để lọc ra các file theo loại + theo tên người chụp.",
                "\n",
                "Ứng dụng sẽ được update trong tương lai.",
                "\n\n",
                "Tài liệu hướng dẫn: ",
                "\n",
                "Video hướng dẫn: ",
                "\n---\n\n",
                "[Red]|Thông tin về tác giả",
                "\n---\n",
                "Chào các bạn, mình là Tuấn, mình là dev nghiệp dư và đang trên \"con đường\" học hỏi nhiều thứ mới.",
                "\n\n",
                "Nếu trong quá trình có gặp vấn đề gì hoặc có góp ý thì các bạn vui lòng góp ý thông qua",
                "\n",
                "Facebook: https://www.facebook.com/tunanguyen19",
                "\n",
                "Email: ",
                "[DodgerBlue]|nguyenanhtuan19122002@gmail.com",
                "\n\n",
                "Xem thêm các dự án khác của mình tại: https://github.com/NguyenAnhTuan1912"
            });
        }

        private void btnOpenMultipleFileNameImportingForm_Click(object sender, EventArgs e)
        {
            FileNamesImporterDialog fniDialog = new FileNamesImporterDialog();
            fniDialog.ShowDialog();
            MessageBox.Show("Tìm thấy: " + fniDialog.lines.Length.ToString() + " file(s).", "TEST", MessageBoxButtons.OK);
        }
        // End button events

    }
}
