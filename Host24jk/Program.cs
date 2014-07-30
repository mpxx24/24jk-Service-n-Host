using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host24jk
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof (_24jk.Service24)))
            {
                host.Open();
                Console.WriteLine("host wystartował: " + DateTime.Now);
                Console.ReadLine();
            }

        }
    }
}
