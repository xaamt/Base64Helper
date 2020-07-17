using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Base64Tools
{
    public partial class Main : Form
    {
        private FileService fileServiceInput { set; get; }
        private FileService fileServiceOutput { set; get; }
        public Main()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            fileServiceInput = new FileService();
            fileServiceOutput = new FileService();

            txtAddress.ResetText();
            txtContent.ResetText();
            txtInfo.ResetText();
            btnBrowse.Enabled = true;
            btnConvert.Enabled = false;
            btnCopy.Enabled = false;

            cbAutoConvert.Checked = true;
            btnBase64Convert.Enabled = false;
            txtBase64Content.ResetText();
            txtBase64Info.ResetText();
            cbExtensions.Text = "File Format (Default: *.txt)";
            cbExtensions.Enabled = false;
            btnSaveAs.Enabled = false;
            btnPreview.Enabled = false;

            
            cbSigTypes.DataSource = null;
            cbSigTypes.Enabled = false;
            lbSigTypesCount.Text = $"Type Count: {0}";
            cbSigTypes.ResetText();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (fileServiceInput.SelectFile())
            {
                txtAddress.Text = $"{fileServiceInput.fileInstance.Path}";

                var dialogResult = MessageBox.Show(@"Do you want to convert this file", "Automatic Convert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    btnConvert_Click(sender,e);
                }
                else
                {
                    txtInfo.Text = $"{fileServiceInput.fileInstance.Name}{fileServiceInput.fileInstance.Extension} is not loaded";
                    btnConvert.Enabled = true;
                }
            }
            else
            {
                txtAddress.Text = string.Empty;
                txtInfo.Text = string.Empty;
                btnConvert.Enabled = false;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (fileServiceInput.UploadFile())
            {
                txtInfo.Text = $"File Loaded, Content Size: {fileServiceInput.GetPopulatedFileSize()}";
                fileServiceInput.ConvertToBase64();
                txtContent.Text = fileServiceInput.fileInstance.ContentInBase64;
                btnCopy.Enabled = true;
            }
            else
            {
                txtInfo.Text = $"{fileServiceInput.fileInstance.Name}{fileServiceInput.fileInstance.Extension} loading failed";
                btnConvert.Enabled = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
            MessageBox.Show("Base 64 Helper app has been reloaded", "Reload the application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtContent.Text);
            MessageBox.Show("Base 64 string has been copied to clipboard", "Copy to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtBase64Content.Text = Clipboard.GetText();
            if(cbAutoConvert.Checked)
            {
                btnBase64Convert_Click(sender, e);
            }
        }

        private void btnBase64Convert_Click(object sender, EventArgs e)
        {
            var base64TextArea = txtBase64Content.Text;

            if (string.IsNullOrWhiteSpace(base64TextArea))
            {
                MessageBox.Show("Base64 string cannot be empty or white space!", "Convert failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbExtensions.Enabled = false;
                btnSaveAs.Enabled = false;
                btnPreview.Enabled = false;

                return;
            }

            fileServiceOutput.fileInstance.ContentInBase64 = base64TextArea;
            fileServiceOutput.ConvertFromBase64();

            if (!fileServiceOutput.fileInstance.HasFileContentInBytes || !fileServiceOutput.fileInstance.HasFileContentInBase64)
            {
                txtBase64Info.Text = $"File Loaded Failed, Base64 Length: {fileServiceOutput.fileInstance.ContentInBase64Size}";
                return;
            }

            var sigTypes = fileServiceOutput.FileSignatureMatcher();

            cbSigTypes.Enabled = true;
            bsSigTypes.DataSource = sigTypes;
            cbSigTypes.DataSource = null;
            cbSigTypes.DataSource = bsSigTypes;

            lbSigTypesCount.Text = $"Type Count: {sigTypes.Count()}";

            txtBase64Info.Text =  $"File Loaded, Content Size: {fileServiceOutput.GetPopulatedFileSize()}, File Type: )";

            cbExtensions.Enabled = true;
            btnSaveAs.Enabled = true;
            btnPreview.Enabled = true;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            fileServiceOutput.SaveFile();
        }

        private void txtBase64Content_TextChanged(object sender, EventArgs e)
        {
            btnBase64Convert.Enabled = txtBase64Content.Text?.Length > 0;
            lblBase64Content.Text = $"Length: {txtBase64Content.TextLength}";
        }
        
        private void btnPreviewExcel_Click(object sender, EventArgs e)
        {
            var fileExtensionCombo = cbExtensions.Text;

            string fileExtenstion;

            switch(fileExtensionCombo)
            {
                case "Excel (*.xlsx, *.xls)": fileExtenstion = "xlsx"; break;
                case "PDF (*.pdf)": fileExtenstion = "pdf"; break;
                case "Image (*.png, *.jpg, *.gif)": fileExtenstion = "jpg"; break;
                case "Text (*.txt, *.xml, *.htm)": fileExtenstion = "txt"; break;
                case "Word (*.docx, *.doc)": fileExtenstion = "docx"; break;
                default: fileExtenstion = "txt"; break;
            }

            fileServiceOutput.Preview(fileExtenstion);
        }
        
        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            lblContentLength.Text = $"Length: {txtContent.TextLength}";
        }

        private void tslblPoweredBy_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://www.xamt.pro");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
