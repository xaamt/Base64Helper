using System;
using System.Diagnostics;
using System.IO;

namespace FileDotNet
{
    public sealed class FileHelper : IFileHelper
    {
        public string ConvertToBase64(byte [] content)
        {
            var result = content?.Length > 0 ? Convert.ToBase64String(content, Base64FormattingOptions.InsertLineBreaks) : null;

            return result;
        }
        public byte[] ConvertFromBase64(string content)
        {
            var result = Convert.FromBase64String(content);

            return result;
        }
        public byte[] LoadFile(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(fileStream))
                {
                    var content = reader.ReadBytes(Convert.ToInt32(fileStream.Length));
                    return content;
                }
            }
        }
        public void SaveFile(byte[] content, string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(content, 0, content.Length);
            }
        }
        public void Preview(byte[] content, string extension = null)
        {
            var tempPath = Path.GetTempPath();
            var tempFile = Path.GetRandomFileName();
            var tempFileWithExtension = $"{tempFile}.{extension ?? "bin"}";
            var fullPath = Path.Combine(tempPath, tempFileWithExtension);

            SaveFile(content, fullPath);
            Process.Start(fullPath);
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
