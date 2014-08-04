using System;
using System.Collections;
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
        public void UploadPicToDb(string imgUrl, string fName, string fNameExt, int fNameSize)
        {
            var context = new Context();

            var plik = new DbFile()
            {
                File = File.ReadAllBytes(imgUrl),
                FileName = fName,
                FileNameExtension = fNameExt,
                AddeDateTime = DateTime.Now,
                FileSize = fNameSize
            };

            context.DbFiles.Add(plik);
            
            context.SaveChanges();
        }
    }
    
}
