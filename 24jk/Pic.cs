namespace _24jk
{
    public class DbFile
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FilenameExtension { get; set; }
        public int FileSize { get; set; }
        public byte[] File { get; set; }
    }
}
