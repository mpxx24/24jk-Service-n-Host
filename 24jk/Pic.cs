namespace _24jk
{
    public class DbFile
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FilenameExtension { get; set; }
        public string FileSize { get; set; } //string?
        public byte[] File { get; set; }
    }
}
