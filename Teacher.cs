using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace AttandancePortal
{
    public class Teacher:Base
    {
        public void TeacherLogin()
        {
            Console.Clear();
            Console.WriteLine("Enter ID");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Teacher's Name:");
            string id = Console.ReadLine();
            Console.Clear();
            foreach (Base items in teachers)
            {
                if (items.ID == id && items.FullName == name)
                {

                    int choice;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("_______________TEACHER PORTAL_________________");
                        Console.WriteLine("Press 1 For Students List\nPress 2 For Add New Student Details\n Press 3 For Remove Student Record\nPress 0 For Logout");
                        choice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (choice)
                        {
                            case 0:
                                goto Exit;
                            case 1:

                                foreach (Base item in students)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Student Name:{item.FullName}\tStudent ID:{item.ID}\tPresenty:{item.Presenty}");
                                }

                                break;
                            case 2:
                                Console.WriteLine("Enter Name, ID and Presenty");
                                Base student = new Base()
                                {
                                    FullName = Console.ReadLine(),
                                    ID = Console.ReadLine(),
                                    Presenty = Console.ReadLine()
                                };
                                students.Add(student);
                                Console.Clear();
                                Console.WriteLine("Student Added Successfully!");
                                break;

                             case 3:
                                Console.Clear();
                                Console.WriteLine("Enter ID of student, You want to remove:");
                                string Delete = Console.ReadLine();
                                foreach (Base stud in students)
                                {
                                    if (stud.ID == Delete)
                                    {
                                        students.Remove(stud);
                                        Console.Clear();
                                        Console.WriteLine("Removed Successfully!");
                                    }
                                }
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid Input");
                                break;


                        }
                    } while (choice != 0);

                }



            }
            Exit:
            Console.WriteLine("");
       
        }

    }
}
