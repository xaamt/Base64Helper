namespace FileDotNet
{
    public class FileSignature
    {
        public string Name { get; set; }
        public byte[] Signature { get; set; }
        public string Extensions { get; set; }

        public FileSignature(string name, string extensions, byte[] signature)
        {
            Name = name;
            Extensions = extensions;
            Signature = signature;
        }

        public FileSignature()
        {

        }

        public int SignatureLength => Signature.Length;

        public override string ToString() => $"{Name} [{Extensions}] (Bytes Matched: {SignatureLength})";
    }
}
