using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace Base84Tools.Common
{
    public sealed class FileService
    {
        public string Name { get; set; }
        public string Extension { set; get; }
        public string Path { get; set; }
        public byte[] ContentInBytes { set; get; }
        public int ContentInBytesSize => ContentInBytes?.Length ?? 0;
        public bool HasFileContentInBytes => ContentInBytesSize > 0;


        public string ContentInBase64
        {
            set
            {
                try
                {
                    ContentInBytes = Convert.FromBase64String(value);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show($"Invalid Base64 string: {ex.Message}", "Invalid Base64 error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error Type: {ex.GetType()}\n\rError message: {ex.Message}", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            get => HasFileContentInBytes ? Convert.ToBase64String(ContentInBytes,Base64FormattingOptions.InsertLineBreaks) : null;
        }

        public int ContentInBase64Size => ContentInBase64?.Length ?? 0;
        public bool HasFileContentInBase64 => ContentInBase64Size > 0;
        
        
        private OpenFileDialog OpenFileDialog { set; get; }
        private SaveFileDialog SaveFileDialog { set; get; }

        public FileService()
        {
            OpenFileDialog = new OpenFileDialog
            {
                Title = "Select a file",
                Filter = "All files|*.*|Images Files|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif|PDF Files|*.pdf",
                CheckFileExists = true,
                CheckPathExists = true
            };

            SaveFileDialog = new SaveFileDialog
            {
                Title = "Save the file", Filter = "All files (*.*)|*.*", CheckPathExists = true
            };
        }

        public bool SelectFile()
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Path = OpenFileDialog.FileName;
                    Name = System.IO.Path.GetFileNameWithoutExtension(Path);
                    Extension = System.IO.Path.GetExtension(Path);
                    return true;
                }
                catch(SecurityException ex)
                {
                    MessageBox.Show($"Error message: {ex.Message}", "Security error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error Type: {ex.GetType()}\n\rError message: {ex.Message}", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return false;
        }

        public bool UploadFile()
        {
            if (!string.IsNullOrWhiteSpace(Path))
            {
                try
                {
                    using (var fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(fileStream))
                        {
                            ContentInBytes = reader.ReadBytes(Convert.ToInt32(fileStream.Length));
                        }
                    }

                    if (ContentInBytes.Length > 0)
                    {
                        MessageBox.Show("Reading the file complete successfully.", "Reading successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }

                    MessageBox.Show("Reading the file Failed or file length is zero!", "Reading failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Error message: {ex.Message}", "Security error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type: {ex.GetType()}\n\rError message: {ex.Message}", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return false;
        }

        public void SaveFile()
        {
            if (HasFileContentInBytes)
            {
                SaveFileDialog.FileName = Name;
                SaveFileDialog.DefaultExt = Extension;

                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var saveFileDialogPath = SaveFileDialog.FileName;

                    try
                    {
                        using (var fileStream = new FileStream(saveFileDialogPath, FileMode.Create, FileAccess.Write))
                        {
                            fileStream.Write(ContentInBytes, 0, ContentInBytesSize);
                        }
                        MessageBox.Show("File saved successfull", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Type: {ex.GetType()}\n\rUnknow error.\n\nError message: {ex.Message}\n\n", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void Preview(string extension = null)
        {
            var tempPath = System.IO.Path.GetTempPath();

            var tempFile = System.IO.Path.GetRandomFileName();

            var tempFileWithExtension = $"{tempFile}.{extension ?? "tmp"}";

            var fullPath = System.IO.Path.Combine(tempPath, tempFileWithExtension);

            if (HasFileContentInBytes)
            {
                try
                {
                    using(var fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                    {
                        fileStream.Write(ContentInBytes, 0, ContentInBytesSize);
                    }

                    Process.Start(fullPath);
                }
                catch(SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}", "Security error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Win32Exception)
                {
                    MessageBox.Show($"There is no default application to open {extension} file.", "No Default Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public string SizeSuffix(long value)
        {
            string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

            if (value < 0) { return "-" + SizeSuffix(-value); }

            var i = 0;
            var dValue = (decimal)value;
            while (Math.Round(dValue / 1024) >= 1)
            {
                dValue /= 1024;
                i++;
            }

            return $"{dValue:n1} {SizeSuffixes[i]}";
        }
    }
}
