using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace AttandancePortal
{
      public class Student : Base
      {
        public void StudentLogin()
        {
            Console.Clear();
            Console.WriteLine("Enter Student's ID");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Student's Name:");
            string id=Console.ReadLine();
            foreach (Base items in students)
            {
                if (items.ID == id && items.FullName == name)
                {
                    Console.Clear();
                    Console.WriteLine("_________STUDENT PORTAL_________");
                    Console.WriteLine($"Attendace:{items.Presenty}");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }
      }
}
