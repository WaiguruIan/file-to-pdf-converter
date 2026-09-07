namespace FileConverterApp
{
    partial class ProgressForm
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
            lblProgressStatus = new Label();
            progressBarPopup = new ProgressBar();
            SuspendLayout();
            // 
            // lblProgressStatus
            // 
            lblProgressStatus.AutoSize = true;
            lblProgressStatus.Location = new Point(83, 31);
            lblProgressStatus.Name = "lblProgressStatus";
            lblProgressStatus.Size = new Size(75, 15);
            lblProgressStatus.TabIndex = 0;
            lblProgressStatus.Text = "Converting...";
            // 
            // progressBarPopup
            // 
            progressBarPopup.Location = new Point(83, 49);
            progressBarPopup.Name = "progressBarPopup";
            progressBarPopup.Size = new Size(182, 21);
            progressBarPopup.Style = ProgressBarStyle.Marquee;
            progressBarPopup.TabIndex = 1;
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 111);
            ControlBox = false;
            Controls.Add(progressBarPopup);
            Controls.Add(lblProgressStatus);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProgressForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProgressForm";
            Load += ProgressForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProgressStatus;
        private ProgressBar progressBarPopup;
    }
}