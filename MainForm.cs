using FileFilter.BLL;
using FileFilter.BLL.Extensions;
using FileFilter.BLL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter
{
    public partial class FileFilterForm : Form
    {
        private static FileBLL _fileBll = new FileBLL();
        private FormHelper _formHelper; 

        public FileFilterForm()
        {
            InitializeComponent();
            _formHelper = new FormHelper(this);

            Init();
        }

        public void Init()
        {
            radGeneralFileName.Checked = true;
            cbxTypeOfFile.DataSource = cbxTypeOfFile.Items;
        }

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
            _formHelper.clearOutputBox();

            _formHelper.appendTextToOutputBox("Đường dẫn tới thư mục nguồn: ");
            _formHelper.appendTextToOutputBoxWithColor(txtSourcePath.Text, Color.Green);

            _formHelper.appendTextToOutputBox("\n");

            _formHelper.appendTextToOutputBox("Đường dẫn tới thư mục đích: ");
            _formHelper.appendTextToOutputBoxWithColor(txtDestinationPath.Text, Color.Green);

            _formHelper.appendTextToOutputBox("\n");

            string typeOfFileOutputText = cbxTypeOfFile.SelectedIndex == 0 ? "File ảnh (JPG/JPEG/PNG/RAW)" : "File tài liệu (TXT/PDF/DOC/DOCX)";
            _formHelper.appendTextToOutputBox("Loại file: ");
            _formHelper.appendTextToOutputBoxWithColor(typeOfFileOutputText, Color.Green);

            _formHelper.appendTextToOutputBox("\n");

            string fileNameOptionOutputText = radGeneralFileName.Checked ? " Tên chung cho nhiều files - " + txtGeneralFileName.Text : "Nhiều tên files";
            _formHelper.appendTextToOutputBox("Bạn chọn: ");
            _formHelper.appendTextToOutputBoxWithColor(fileNameOptionOutputText, Color.Green);

            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("\n");

            int foundFileOutputText = 0;
            _formHelper.appendTextToOutputBox("Đã tìm thấy: ");
            _formHelper.appendTextToOutputBoxWithColor(String.Format("{0} file(s).", foundFileOutputText), foundFileOutputText == 0 ? Color.Red : Color.Green);
        }

        private void btnOpenInformationForm_Click(object sender, EventArgs e)
        {
            _formHelper.clearOutputBox();

            _formHelper.appendTextToOutputBox("File Filter");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Phiên bản hiện tại: ");
            _formHelper.appendTextToOutputBoxWithColor("1.0.0", Color.Green);
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Được viết bởi: ");
            _formHelper.appendTextToOutputBoxWithColor("Nguyen Anh Tuan", Color.Green);

            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("\n");

            _formHelper.appendTextToOutputBoxWithColor("Thông tin về File Filter", Color.Red);
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("---");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox(
                "Là ứng dụng dùng để lọc file theo LOẠI của file. " +
                "Các bạn có thể dùng để lọc theo tên chung, hoặc lọc theo nhiều tên. " +
                "Ứng dụng này ban đầu được tạo ra dành cho các thợ chụp hình/người hay chụp ảnh/nhiếp ảnh gia " +
                "dùng để lọc ra các file theo loại + theo tên người chụp." +
            "");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Ứng dụng sẽ được update trong tưuong lai.");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Tài liệu hướng dẫn: ");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Video hướng dẫn: ");

            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("---");

            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("\n");

            _formHelper.appendTextToOutputBoxWithColor("Thông tin về tác giả", Color.Red);
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("---");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Với định hướng là một Front-end developer (hiện tại thì có thêm Back-end, Mobile developer), thì mình làm ra ứng dụng này là để học thêm nhiều về C# và Window Form.");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Nếu trong quá trình có gặp vấn đề gì hoặc có góp ý thì các bạn vui lòng góp ý thông qua");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Facebook: https://www.facebook.com/tunanguyen19");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("E-mail: ");
            _formHelper.appendTextToOutputBoxWithColor("nguyenanhtuan19122002@gmail.com", Color.DodgerBlue);
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("\n");
            _formHelper.appendTextToOutputBox("Xem thêm các dự án khác của mình tại: https://github.com/NguyenAnhTuan1912");
        }
    }
}
