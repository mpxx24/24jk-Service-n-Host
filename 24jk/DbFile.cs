using System;

namespace _24jk
{
    public class DbFile
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FileNameExtension { get; set; }
        public int FileSize { get; set; }

        public DateTime AddeDateTime { get; set; }
        public byte[] File { get; set; }
    }
}
