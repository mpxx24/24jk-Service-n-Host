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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service24" in both code and config file together.
    public class Service24 : IService24
    {
        public void UploadPicToDb(string imgUrl)
        {
            var context = new Context();

            var pic = new Pic
            {
                File = File.ReadAllBytes(imgUrl)
            };

            var pList = new PicList();
            pList.Title = "Lista Zdjęć";

            pList.Pics = new List<Pic> { pic };
            context.PicLists.Add(pList);
            context.SaveChanges();
        }
    }
    
}
