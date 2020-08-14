using System.Collections.Generic;

namespace FileDotNet
{
    public interface IFileHelper
    {
        string ConvertToBase64(byte[] content, bool insertLineBreak = false);
        byte[] ConvertFromBase64(string content);
        byte[] LoadFile(string path);
        void SaveFile(byte[] content, string path);
        void Preview(byte[] content, string extension = null);
        string SizeSuffix(long value);
        IEnumerable<FileSignature> FileSignatureMatcher(byte[] file);
    }
}
