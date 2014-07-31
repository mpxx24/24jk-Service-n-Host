using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        byte[] UploadPicToDb(string imgUrl, string fName, string fNameExt, int fNameSize);

    }
}
