namespace FileConverterApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSelectFile = new Button();
            lblNoFile = new Label();
            btnConvert = new Button();
            lblStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            btnChooseOutput = new Button();
            lblOutputFolder = new Label();
            label3 = new Label();
            pnlDropZone = new Panel();
            lblFilePath = new Label();
            picFileIcon = new PictureBox();
            label4 = new Label();
            pnlDropZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFileIcon).BeginInit();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(151, 134);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(251, 42);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // lblNoFile
            // 
            lblNoFile.AutoSize = true;
            lblNoFile.Location = new Point(233, 179);
            lblNoFile.Name = "lblNoFile";
            lblNoFile.Size = new Size(88, 15);
            lblNoFile.TabIndex = 1;
            lblNoFile.Text = "No file selected";
            lblNoFile.Click += lbFilePath_Click;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.FromArgb(37, 99, 235);
            btnConvert.Enabled = false;
            btnConvert.FlatAppearance.BorderSize = 0;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = Color.White;
            btnConvert.Location = new Point(68, 565);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(717, 57);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert to PDF";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += button2_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(356, 536);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(111, 27);
            label1.Name = "label1";
            label1.Size = new Size(326, 38);
            label1.TabIndex = 5;
            label1.Text = "Drag and drop files here";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 97);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 6;
            label2.Text = "OR";
            label2.Click += label2_Click;
            // 
            // btnChooseOutput
            // 
            btnChooseOutput.Location = new Point(142, 469);
            btnChooseOutput.Name = "btnChooseOutput";
            btnChooseOutput.Size = new Size(214, 34);
            btnChooseOutput.TabIndex = 7;
            btnChooseOutput.Text = "Choose Output Folder";
            btnChooseOutput.UseVisualStyleBackColor = true;
            btnChooseOutput.Click += btnChooseOutput_Click;
            // 
            // lblOutputFolder
            // 
            lblOutputFolder.AutoSize = true;
            lblOutputFolder.Location = new Point(142, 506);
            lblOutputFolder.Name = "lblOutputFolder";
            lblOutputFolder.Size = new Size(189, 15);
            lblOutputFolder.TabIndex = 8;
            lblOutputFolder.Text = "Default: same folder as original file";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(32, 22);
            label3.Name = "label3";
            label3.Size = new Size(324, 60);
            label3.TabIndex = 9;
            label3.Text = "Convert Your Files";
            // 
            // pnlDropZone
            // 
            pnlDropZone.Controls.Add(lblFilePath);
            pnlDropZone.Controls.Add(picFileIcon);
            pnlDropZone.Controls.Add(label4);
            pnlDropZone.Controls.Add(label1);
            pnlDropZone.Controls.Add(btnSelectFile);
            pnlDropZone.Controls.Add(lblNoFile);
            pnlDropZone.Controls.Add(label2);
            pnlDropZone.Location = new Point(135, 106);
            pnlDropZone.Name = "pnlDropZone";
            pnlDropZone.Size = new Size(566, 336);
            pnlDropZone.TabIndex = 10;
            pnlDropZone.Paint += panel1_Paint;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(57, 302);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(38, 15);
            lblFilePath.TabIndex = 8;
            lblFilePath.Text = "label5";
            lblFilePath.Visible = false;
            // 
            // picFileIcon
            // 
            picFileIcon.Location = new Point(57, 220);
            picFileIcon.Name = "picFileIcon";
            picFileIcon.Size = new Size(75, 79);
            picFileIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picFileIcon.TabIndex = 7;
            picFileIcon.TabStop = false;
            picFileIcon.Visible = false;
            // 
            // label4
            // 
            label4.Location = new Point(111, 18);
            label4.Name = "label4";
            label4.Size = new Size(326, 78);
            label4.TabIndex = 5;
            label4.Text = "Drag and drop files here";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label1_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(815, 742);
            Controls.Add(pnlDropZone);
            Controls.Add(label3);
            Controls.Add(lblOutputFolder);
            Controls.Add(btnChooseOutput);
            Controls.Add(lblStatus);
            Controls.Add(btnConvert);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "File to PDF Converter";
            Load += Form1_Load;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            Paint += Form1_Paint;
            pnlDropZone.ResumeLayout(false);
            pnlDropZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFileIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label lblNoFile;
        private Button btnConvert;
        private Label lblStatus;
        private Label label1;
        private Label label2;
        private Button btnChooseOutput;
        private Label lblOutputFolder;
        private Label label3;
        private Panel pnlDropZone;
        private Label label4;
        private PictureBox picFileIcon;
        private Label lblFilePath;
    }
}
