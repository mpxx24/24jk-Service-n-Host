using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _24jk
{
    [ServiceContract]
    public interface IService24
    {
        [OperationContract]
        void UploadPicToDb(string imgUrl, string fName, string fNameExt, int fNameSize);
        //[OperationContract]
        //IEnumerable<byte[]> ListFByte(DbSet<DbFile> listFiles);
        //[OperationContract]
        //IEnumerable<DbFile> GetFiles(DbSet<DbFile> dbSet);

    }
}
