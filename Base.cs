using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace AttandancePortal
{
    public class Base
    {
        public string FullName { get; set; }
        public string ID { get; set; }
        public string Presenty { get; set; }

         public  List<Base> students = new List<Base>();

        public List<Base> teachers = new List<Base>();

       


    }
}
