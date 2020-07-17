using FileDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace Base64Tools
{
    public sealed class FileService
    {
        public FileInstance fileInstance { private set; get; }
        private IFileHelper fileHelper { get; }
        private OpenFileDialog OpenFileDialog { get; }
        private SaveFileDialog SaveFileDialog { get; }

        public FileService()
        {
            fileHelper = new FileHelper();
            fileInstance = new FileInstance();
            OpenFileDialog = new OpenFileDialog
            {
                Title = "Select a file",
                Filter = "All files|*.*|Images Files|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif|PDF Files|*.pdf",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false
            };
            SaveFileDialog = new SaveFileDialog
            {
                Title = "Save the file",
                Filter = "All files (*.*)|*.*",
                CheckPathExists = true
            };
        }

        public bool SelectFile()
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = OpenFileDialog.FileName;
                try
                {
                    fileInstance.Path = path;
                    fileInstance.Name = Path.GetFileNameWithoutExtension(path);
                    fileInstance.Extension = Path.GetExtension(path);

                    return true;
                }
                catch(SecurityException ex)
                {
                    MessageBox.Show($"Error message: {ex.Message}", "Security error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error Type: {ex.GetType()}\n\rError message: {ex.Message}", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            return false;
        }

        public bool UploadFile()
        {
            if (!string.IsNullOrWhiteSpace(fileInstance.Path))
            {
                try
                {
                    var ContentInBytes = fileHelper.LoadFile(fileInstance.Path);

                    if (ContentInBytes.Length > 0)
                    {
                        MessageBox.Show("Reading the file complete successfully.", "Reading successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fileInstance.ContentInBytes = ContentInBytes;
                        return true;
                    }

                    MessageBox.Show("Reading the file Failed or file length is zero!", "Reading failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Error message: {ex.Message}", "Security error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Type: {ex.GetType()}\n\rError message: {ex.Message}", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public void SaveFile()
        {
            if (fileInstance.HasFileContentInBytes)
            {
                SaveFileDialog.FileName = fileInstance.Name;
                SaveFileDialog.DefaultExt = fileInstance.Extension;

                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var saveFileDialogPath = SaveFileDialog.FileName;

                    try
                    {
                        fileHelper.SaveFile(fileInstance.ContentInBytes,saveFileDialogPath);
                        
                        MessageBox.Show("File saved successfull", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Type: {ex.GetType()}\n\rUnknow error.\n\nError message: {ex.Message}\n\n", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void Preview(string extension)
        {
            if (fileInstance.HasFileContentInBytes)
            {
                try
                {
                    fileHelper.Preview(fileInstance.ContentInBytes, extension);
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

        public void ConvertToBase64()
        {
            try
            {
                var result = fileHelper.ConvertToBase64(fileInstance.ContentInBytes);

                if (result == null)
                {
                    MessageBox.Show("Invalid file content ", "Invalid Base64 error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fileInstance.ContentInBase64 = result;  
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid Base64 string: {ex.Message}", "Invalid Base64 error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Type: {ex.GetType()}\n\rError message: {ex.Message}", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ConvertFromBase64()
        {
            try
            {
                var result = fileHelper.ConvertFromBase64(fileInstance.ContentInBase64);

                if (result?.Length > 0)
                {
                    fileInstance.ContentInBytes = result;
                }
                else
                {
                    MessageBox.Show("Invalid Base64 string content ", "Invalid Base64 error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid Base64 string: {ex.Message}", "Invalid Base64 error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Type: {ex.GetType()}\n\rError message: {ex.Message}", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string GetPopulatedFileSize()
        {
            return fileHelper.SizeSuffix(fileInstance.ContentInBytesSize);
        }

        public IEnumerable<FileSignature> FileSignatureMatcher()
        {
            var fileSignatures = fileHelper.FileSignatureMatcher(fileInstance.ContentInBytes);

            //if (fileSignature != null)
            //{
            //    return (fileSignature.Name, fileSignature.Extensions);
            //}

            //return ("Unknown", "tmp");

            return fileSignatures;
        }
    }
}
