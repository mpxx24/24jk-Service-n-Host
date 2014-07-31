using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace _24jk
{
    public class Service24 : IService24
    {     
        public byte[] UploadPicToDb(string imgUrl, string fName, string fNameExt, int fNameSize)
        {
            var context = new Context();

            var pic = new DbFile()
            {
                File = File.ReadAllBytes(imgUrl),
                FileName = fName,
                FilenameExtension = fNameExt,
                FileSize = fNameSize
            };

            context.DbFiles.Add(pic);
            
            context.SaveChanges();
            return pic.File;
        }
    }
    
}
