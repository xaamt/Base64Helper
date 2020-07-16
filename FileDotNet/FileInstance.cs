namespace FileDotNet
{
    public class FileInstance
    {
        public string Name { get; set; }
        public string Extension { set; get; }
        public string Path { get; set; }
        public byte[] ContentInBytes { set; get; }
        public int ContentInBytesSize => ContentInBytes?.Length ?? 0;
        public bool HasFileContentInBytes => ContentInBytesSize > 0;
        public string ContentInBase64 { set; get; }
        public int ContentInBase64Size => ContentInBase64?.Length ?? 0;
        public bool HasFileContentInBase64 => ContentInBase64Size > 0;
    }
}
