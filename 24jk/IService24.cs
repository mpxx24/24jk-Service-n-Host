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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService24" in both code and config file together.
    [ServiceContract]
    public interface IService24
    {
        [OperationContract]
        void UploadPicToDb(string imgUrl);
    }
}
