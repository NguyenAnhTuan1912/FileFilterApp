namespace FileFilter
{
    partial class FileFilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.btnOpenSourceFB = new System.Windows.Forms.Button();
            this.btnOpenDestinationFB = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTypeOfFile = new System.Windows.Forms.ComboBox();
            this.btnCopyAndMove = new System.Windows.Forms.Button();
            this.btnJustMove = new System.Windows.Forms.Button();
            this.btnOpenInformationForm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMultipleFileNamesStatus = new System.Windows.Forms.Label();
            this.btnOpenMultipleFileNameImportingForm = new System.Windows.Forms.Button();
            this.radMultipleFileNameImportingForm = new System.Windows.Forms.RadioButton();
            this.radGeneralFileName = new System.Windows.Forms.RadioButton();
            this.txtGeneralFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ltvFiles = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeOfFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckBeforeRun = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "FILE FILTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "version: 1.0.0, made by Nguyen Anh Tuan";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbOutput.BackColor = System.Drawing.SystemColors.Window;
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbOutput.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(29, 415);
            this.rtbOutput.MinimumSize = new System.Drawing.Size(706, 130);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(706, 219);
            this.rtbOutput.TabIndex = 6;
            this.rtbOutput.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(97, 378);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(638, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đường dẫn thư mục gốc:";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(181, 35);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(401, 25);
            this.txtSourcePath.TabIndex = 1;
            // 
            // btnOpenSourceFB
            // 
            this.btnOpenSourceFB.Location = new System.Drawing.Point(589, 35);
            this.btnOpenSourceFB.Name = "btnOpenSourceFB";
            this.btnOpenSourceFB.Size = new System.Drawing.Size(94, 25);
            this.btnOpenSourceFB.TabIndex = 2;
            this.btnOpenSourceFB.Text = "Chọn";
            this.btnOpenSourceFB.UseVisualStyleBackColor = true;
            this.btnOpenSourceFB.Click += new System.EventHandler(this.btnOpenSourceFB_Click);
            // 
            // btnOpenDestinationFB
            // 
            this.btnOpenDestinationFB.Location = new System.Drawing.Point(589, 76);
            this.btnOpenDestinationFB.Name = "btnOpenDestinationFB";
            this.btnOpenDestinationFB.Size = new System.Drawing.Size(94, 25);
            this.btnOpenDestinationFB.TabIndex = 4;
            this.btnOpenDestinationFB.Text = "Chọn";
            this.btnOpenDestinationFB.UseVisualStyleBackColor = true;
            this.btnOpenDestinationFB.Click += new System.EventHandler(this.btnOpenDestinationFB_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(181, 76);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(401, 25);
            this.txtDestinationPath.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đường dẫn thư mục đích:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Loại file:";
            // 
            // cbxTypeOfFile
            // 
            this.cbxTypeOfFile.FormattingEnabled = true;
            this.cbxTypeOfFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxTypeOfFile.Items.AddRange(new object[] {
            "Image Files",
            "Document Files"});
            this.cbxTypeOfFile.Location = new System.Drawing.Point(181, 117);
            this.cbxTypeOfFile.Name = "cbxTypeOfFile";
            this.cbxTypeOfFile.Size = new System.Drawing.Size(224, 26);
            this.cbxTypeOfFile.TabIndex = 5;
            // 
            // btnCopyAndMove
            // 
            this.btnCopyAndMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyAndMove.Location = new System.Drawing.Point(762, 378);
            this.btnCopyAndMove.Name = "btnCopyAndMove";
            this.btnCopyAndMove.Size = new System.Drawing.Size(467, 35);
            this.btnCopyAndMove.TabIndex = 11;
            this.btnCopyAndMove.Text = "Copy và chuyển file";
            this.btnCopyAndMove.UseVisualStyleBackColor = true;
            // 
            // btnJustMove
            // 
            this.btnJustMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJustMove.Location = new System.Drawing.Point(762, 419);
            this.btnJustMove.Name = "btnJustMove";
            this.btnJustMove.Size = new System.Drawing.Size(467, 35);
            this.btnJustMove.TabIndex = 12;
            this.btnJustMove.Text = "Chỉ chuyển file";
            this.btnJustMove.UseVisualStyleBackColor = true;
            // 
            // btnOpenInformationForm
            // 
            this.btnOpenInformationForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenInformationForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenInformationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenInformationForm.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnOpenInformationForm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenInformationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenInformationForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenInformationForm.Location = new System.Drawing.Point(762, 599);
            this.btnOpenInformationForm.Name = "btnOpenInformationForm";
            this.btnOpenInformationForm.Size = new System.Drawing.Size(467, 35);
            this.btnOpenInformationForm.TabIndex = 13;
            this.btnOpenInformationForm.Text = "Thông tin";
            this.btnOpenInformationForm.UseVisualStyleBackColor = false;
            this.btnOpenInformationForm.Click += new System.EventHandler(this.btnOpenInformationForm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMultipleFileNamesStatus);
            this.groupBox2.Controls.Add(this.btnOpenMultipleFileNameImportingForm);
            this.groupBox2.Controls.Add(this.radMultipleFileNameImportingForm);
            this.groupBox2.Controls.Add(this.radGeneralFileName);
            this.groupBox2.Controls.Add(this.txtGeneralFileName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSourcePath);
            this.groupBox2.Controls.Add(this.btnOpenSourceFB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxTypeOfFile);
            this.groupBox2.Controls.Add(this.txtDestinationPath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnOpenDestinationFB);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(29, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox2.Size = new System.Drawing.Size(706, 244);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lblMultipleFileNamesStatus
            // 
            this.lblMultipleFileNamesStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMultipleFileNamesStatus.AutoSize = true;
            this.lblMultipleFileNamesStatus.Location = new System.Drawing.Point(281, 203);
            this.lblMultipleFileNamesStatus.Name = "lblMultipleFileNamesStatus";
            this.lblMultipleFileNamesStatus.Size = new System.Drawing.Size(0, 18);
            this.lblMultipleFileNamesStatus.TabIndex = 24;
            this.lblMultipleFileNamesStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOpenMultipleFileNameImportingForm
            // 
            this.btnOpenMultipleFileNameImportingForm.Location = new System.Drawing.Point(181, 200);
            this.btnOpenMultipleFileNameImportingForm.Name = "btnOpenMultipleFileNameImportingForm";
            this.btnOpenMultipleFileNameImportingForm.Size = new System.Drawing.Size(94, 25);
            this.btnOpenMultipleFileNameImportingForm.TabIndex = 9;
            this.btnOpenMultipleFileNameImportingForm.Text = "Mở hộp thoại";
            this.btnOpenMultipleFileNameImportingForm.UseVisualStyleBackColor = true;
            // 
            // radMultipleFileNameImportingForm
            // 
            this.radMultipleFileNameImportingForm.AutoSize = true;
            this.radMultipleFileNameImportingForm.Location = new System.Drawing.Point(26, 201);
            this.radMultipleFileNameImportingForm.Name = "radMultipleFileNameImportingForm";
            this.radMultipleFileNameImportingForm.Size = new System.Drawing.Size(104, 22);
            this.radMultipleFileNameImportingForm.TabIndex = 8;
            this.radMultipleFileNameImportingForm.TabStop = true;
            this.radMultipleFileNameImportingForm.Text = "Tên nhiều file:";
            this.radMultipleFileNameImportingForm.UseVisualStyleBackColor = true;
            this.radMultipleFileNameImportingForm.CheckedChanged += new System.EventHandler(this.radMultipleFileNameImportingForm_CheckedChanged);
            // 
            // radGeneralFileName
            // 
            this.radGeneralFileName.AutoSize = true;
            this.radGeneralFileName.Location = new System.Drawing.Point(26, 160);
            this.radGeneralFileName.Name = "radGeneralFileName";
            this.radGeneralFileName.Size = new System.Drawing.Size(108, 22);
            this.radGeneralFileName.TabIndex = 6;
            this.radGeneralFileName.TabStop = true;
            this.radGeneralFileName.Text = "Tên file chung:";
            this.radGeneralFileName.UseVisualStyleBackColor = true;
            this.radGeneralFileName.CheckedChanged += new System.EventHandler(this.radGeneralFileName_CheckedChanged);
            // 
            // txtGeneralFileName
            // 
            this.txtGeneralFileName.Location = new System.Drawing.Point(181, 159);
            this.txtGeneralFileName.Name = "txtGeneralFileName";
            this.txtGeneralFileName.Size = new System.Drawing.Size(224, 25);
            this.txtGeneralFileName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tiến trình:";
            // 
            // ltvFiles
            // 
            this.ltvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.fileExtension,
            this.typeOfFile,
            this.dateModified});
            this.ltvFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltvFiles.HideSelection = false;
            this.ltvFiles.Location = new System.Drawing.Point(762, 56);
            this.ltvFiles.Name = "ltvFiles";
            this.ltvFiles.Size = new System.Drawing.Size(467, 278);
            this.ltvFiles.TabIndex = 14;
            this.ltvFiles.UseCompatibleStateImageBehavior = false;
            this.ltvFiles.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "File";
            this.fileName.Width = 100;
            // 
            // fileExtension
            // 
            this.fileExtension.Text = "Extension";
            this.fileExtension.Width = 100;
            // 
            // typeOfFile
            // 
            this.typeOfFile.Text = "Type";
            this.typeOfFile.Width = 100;
            // 
            // dateModified
            // 
            this.dateModified.Text = "Date Modified";
            this.dateModified.Width = 100;
            // 
            // btnCheckBeforeRun
            // 
            this.btnCheckBeforeRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckBeforeRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheckBeforeRun.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCheckBeforeRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBeforeRun.Location = new System.Drawing.Point(762, 558);
            this.btnCheckBeforeRun.Name = "btnCheckBeforeRun";
            this.btnCheckBeforeRun.Size = new System.Drawing.Size(467, 35);
            this.btnCheckBeforeRun.TabIndex = 10;
            this.btnCheckBeforeRun.Text = "Kiểm tra";
            this.btnCheckBeforeRun.UseVisualStyleBackColor = false;
            this.btnCheckBeforeRun.Click += new System.EventHandler(this.btnCheckBeforeRun_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(759, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Danh sách các files:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1125, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tìm thấy 0 file(s)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FileFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1252, 657);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCheckBeforeRun);
            this.Controls.Add(this.ltvFiles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOpenInformationForm);
            this.Controls.Add(this.btnJustMove);
            this.Controls.Add(this.btnCopyAndMove);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1268, 606);
            this.Name = "FileFilterForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " File Filter";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button btnOpenSourceFB;
        private System.Windows.Forms.Button btnOpenDestinationFB;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTypeOfFile;
        private System.Windows.Forms.Button btnCopyAndMove;
        private System.Windows.Forms.Button btnJustMove;
        private System.Windows.Forms.Button btnOpenInformationForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGeneralFileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpenMultipleFileNameImportingForm;
        private System.Windows.Forms.RadioButton radMultipleFileNameImportingForm;
        private System.Windows.Forms.RadioButton radGeneralFileName;
        private System.Windows.Forms.ListView ltvFiles;
        private System.Windows.Forms.Button btnCheckBeforeRun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader fileExtension;
        private System.Windows.Forms.ColumnHeader typeOfFile;
        private System.Windows.Forms.ColumnHeader dateModified;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMultipleFileNamesStatus;
        public System.Windows.Forms.RichTextBox rtbOutput;
    }
}

