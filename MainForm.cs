using FileFilter.BLL;
using FileFilter.Extensions;
using FileFilter.Helpers;
using FileFilter.DTO;
using FileFilter.Utilities;
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
using static System.Net.WebRequestMethods;
using System.Security.Cryptography;

namespace FileFilter
{
    public partial class FileFilterForm : Form
    {
        private FileBLL _fileBll;
        private FormHelper _formHelper;
        private string[] _appInformationTemplate;
        private string[] _appChecklogTemplate;

        public FileFilterForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            radGeneralFileName.Checked = true;
            ckbSaveToNewFolder.Checked = true;
            ckbSeparateFiles.Checked = true;
            cbxTypeOfFile.DataSource = cbxTypeOfFile.Items;

            _formHelper = new FormHelper();
            _fileBll = FileBLL.GetInstance();
            _appChecklogTemplate = _fileBll.readInTextFile(Path.Combine(FileBLL.ProjectDir, "Other", "AppCheckLogTemplate.txt"));
            _appInformationTemplate = _fileBll.readInTextFile(Path.Combine(FileBLL.ProjectDir, "Other", "AppInformationTemplate.txt"));
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
            txtSourcePath.Text = FileBLL.ShowFolderBrowseDialog();
        }

        private void btnOpenDestinationFB_Click(object sender, EventArgs e)
        {
            txtDestinationPath.Text = FileBLL.ShowFolderBrowseDialog();
        }

        private void btnCheckBeforeRun_Click(object sender, EventArgs e)
        {
            string sourcePath = txtSourcePath.Text;
            string destinationPath = txtDestinationPath.Text;
            string extension = cbxTypeOfFile.SelectedIndex == 0 ? "JPG|jpg|JPEG|jpeg|PNG|png|RAW|raw" : "TXT|txt|PDF|pdf|DOC|doc|DOCX|docx";
            string generalFileName = txtGeneralFileName.Text;
            string fileNameOption = radGeneralFileName.Checked ? " Tên chung cho nhiều files - " + txtGeneralFileName.Text : "Nhiều tên files";
            string separateFilesOption = ckbSeparateFiles.Checked ? "Có" : "Không";
            string separateFilesOptionColor = ckbSeparateFiles.Checked ? "Green" : "Red";
            List<FileInfo> files = _fileBll.getAllFilesInfo(sourcePath, generalFileName, extension);

            string textResultOfSourcePathOutputTextAfterValidate = "[Green]|(Đường dẫn hợp lệ!)";
            string textResultOfSourcePathOutputTextAfterCheck = "[Green]|(Thư mục tồn tại!)";
            if(!ValidatorUtility.ValidateFullFolderPath(sourcePath))
            {
                textResultOfSourcePathOutputTextAfterValidate = "[Red]|(Đường dẫn không hợp lệ!)";
                if (!_fileBll.isDirectoryExist(sourcePath)) textResultOfSourcePathOutputTextAfterCheck = "[Red]|(Thư mục không tồn tại!)";
            }

            string textResultOfDestinationPathOutputTextAfterValidate = "[Green]| (Đường dẫn hợp lệ!)";
            string textResultOfDestinationPathOutputTextAfterCheck = "[Green]|(Thư mục tồn tại!)";
            if (!ValidatorUtility.ValidateFullFolderPath(destinationPath))
            {
                textResultOfDestinationPathOutputTextAfterValidate = "[Red]|(Đường dẫn không hợp lệ!)";
                if (!_fileBll.isDirectoryExist(destinationPath)) textResultOfDestinationPathOutputTextAfterCheck = "[Red]|(Thư mục không tồn tại!)";
            }

            string textResultOfGeneralFileNameAfterValidate = "[Green]|(Tên file chung hợp lệ!)";
            if(!ValidatorUtility.ValidateText(generalFileName))
            {
                textResultOfGeneralFileNameAfterValidate = "[Red]| (Tên file chung không hợp lệ!)";
            }
            if(txtGeneralFileName.Text == "")
            {
                textResultOfGeneralFileNameAfterValidate = "[Red]|(Không có)";
            }

            string textResultOfNewForlderOptionAfterValidate = "[Green]|" + txtNewFolderName.Text + " (Có)";
            if(ckbSaveToNewFolder.Checked)
            {
                txtNewFolderName.Text = txtNewFolderName.Text == "" ?  "New Folder" : txtNewFolderName.Text;
                textResultOfNewForlderOptionAfterValidate = "[Green]|" + txtNewFolderName.Text + " (Mặc định)";
            }

            int foundFileOutputText = files.Count();
            lblLVFoundFileNumbers.Text = String.Format("Tìm thấy {0} file(s)", foundFileOutputText.ToString());

            _formHelper.insertToListView(ltvFiles, files);

            _formHelper.clearOutputBox(rtbOutput);

            _formHelper.writeLinesToRichTextBox(rtbOutput, new List<string>
            {
                String.Format("Đường dẫn tới thư mục nguồn: {0} ", sourcePath),
                textResultOfSourcePathOutputTextAfterValidate,
                textResultOfSourcePathOutputTextAfterCheck,
                "\n",
                String.Format("Đường dẫn tới thư mục đích: {0} ", destinationPath),
                textResultOfDestinationPathOutputTextAfterValidate,
                textResultOfDestinationPathOutputTextAfterCheck,
                "\n",
                "Loại file: ",
                String.Format("[Green]|File ({0})", extension),
                "\n",
                "Bạn chọn: ",
                String.Format("[Green]|{0} ", fileNameOption),
                "\n",
                String.Format("Tên file chung: {0} ", generalFileName),
                textResultOfGeneralFileNameAfterValidate,
                "\n",
                "Lưu trong thư mục mới (thư mục con của thư mục đích):  ",
                textResultOfNewForlderOptionAfterValidate,
                "\n",
                "Tách các files: ",
                String.Format("[{0}]|{1} ", separateFilesOptionColor, separateFilesOption),
                "\n\n",
                "Đã tìm thấy: ",
                String.Format("[{0}]|{1} file(s). ", foundFileOutputText == 0 ? "Red" : "Green", foundFileOutputText)
            });
        }

        private void btnOpenInformationForm_Click(object sender, EventArgs e)
        {
            _formHelper.clearOutputBox(rtbOutput);
            _formHelper.writeLinesToRichTextBox(rtbOutput, _appInformationTemplate.ToList());

            /*
            _formHelper.writeLinesToRichTextBox(rtbOutput, new List<string>
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
            */
        }

        private void btnOpenMultipleFileNameImportingForm_Click(object sender, EventArgs e)
        {
            FileNamesImporterDialog fniDialog = new FileNamesImporterDialog();
            fniDialog.ShowDialog();
            // numberOfExistedFilesFromImportFileNamesFind = fniDialog.numberOfExistedFiles;
            MessageBoxUtility.ShowInfo(_fileBll.fileNames.Length.ToString());
        }
        // End button events

    }
}
