using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;

namespace FileConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        [StructLayout(LayoutKind.Sequential)]
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        private Icon GetFileIcon(string filePath)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            SHGetFileInfo(filePath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), 0x000000100 | 0x000000000);
            return Icon.FromHandle(shinfo.hIcon);
        }

        private void UpdateFileDisplay(string filePath)
        {
            lblNoFile.Visible = false;

            lblFilePath.Text = Path.GetFileName(filePath);
            lblFilePath.ForeColor = Color.Black;
            lblFilePath.Visible = true;
            picFileIcon.Visible = true;

            try
            {
                Icon fileIcon = GetFileIcon(filePath);
                picFileIcon.Image = fileIcon.ToBitmap();
            }
            catch
            {
                picFileIcon.Image = null;
                picFileIcon.Visible = false;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a file first.");
                return;
            }

            string sofficePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libre", "LibreOfficePortable", "App", "libreoffice", "program", "soffice.exe");

            if (!File.Exists(sofficePath))
            {
                MessageBox.Show("Conversion engine not found. Please reinstall the app.");
                return;
            }

            string outputDir = !string.IsNullOrEmpty(customOutputFolder)
                ? customOutputFolder
                : Path.GetDirectoryName(selectedFilePath) ?? "";

            btnConvert.Enabled = false;
            btnSelectFile.Enabled = false;

            ProgressForm progressForm = new ProgressForm();
            progressForm.Show(this);

            try
            {
                await Task.Run(() =>
                {
                    string tempProfile = Path.Combine(Path.GetTempPath(), "LOProfile_" + Guid.NewGuid().ToString());
                    string expectedPdfPath = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(selectedFilePath) + ".pdf");

                    if (File.Exists(expectedPdfPath))
                    {
                        File.Delete(expectedPdfPath);
                    }

                    var psi = new ProcessStartInfo
                    {
                        FileName = sofficePath,
                        Arguments = $"--headless --convert-to pdf --outdir \"{outputDir}\" \"{selectedFilePath}\" -env:UserInstallation=file:///{tempProfile.Replace("\\", "/")}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using var process = Process.Start(psi);
                    process.WaitForExit();

                    try { Directory.Delete(tempProfile, true); } catch { }

                    if (!File.Exists(expectedPdfPath))
                    {
                        throw new Exception("Conversion failed: output PDF was not created.");
                    }
                });

                progressForm.Close();
                MessageBox.Show($"Conversion complete!\nSaved to: {outputDir}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                progressForm.Close();
                MessageBox.Show($"Conversion failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConvert.Enabled = true;
                btnSelectFile.Enabled = true;
            }
        }

        private string selectedFilePath = "";

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documents|*.docx;*.doc;*.pptx;*.ppt;*.xlsx;*.xls;*.odt;*.ods;*.odp;*.rtf;*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                UpdateFileDisplay(selectedFilePath);
                btnConvert.Enabled = true;
            }
        }

        private void lbFilePath_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                selectedFilePath = files[0];
                UpdateFileDisplay(selectedFilePath);
                btnConvert.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string customOutputFolder = "";
        private void btnChooseOutput_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                customOutputFolder = folderDialog.SelectedPath;
                lblOutputFolder.Text = $"Output: {customOutputFolder}";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using Pen dashPen = new Pen(Color.FromArgb(180, 180, 180), 2);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawRectangle(dashPen, 1, 1, pnlDropZone.Width - 3, pnlDropZone.Height - 3);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}