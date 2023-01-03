using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
#nullable disable
namespace AttandancePortal
{
    public class Admin : Base 
    {
          
        private const string ID_Admin = "10000";

        private const string Admin_Name = "DILEEP KUMAR";
        public void AdminLogin() 
        {
            Console.Clear();
            Console.WriteLine("Enter ID:");
            string id=Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            string name=Console.ReadLine();
            Console.Clear();
           
            if(id==ID_Admin&&name==Admin_Name)
            {
                int choice;
                do
                {
                    here:
                    Console.WriteLine("___________ADMIN PORTAL___________");
                    Console.WriteLine("Press 1 For Students List\nPress 2 For Add New Student Details\nPress 3 For Remove Student Record\nPress 4 For Teachers List\nPress 5 For Add New Teacher Details\nPress 6 For Remove Teacher Records\nPress 0 For Logout");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear() ;
                    switch (choice)
                    {
                        case 0:
                            goto Exit;
                        case 1:

                            foreach (Base items in students)
                            {
                              Console.WriteLine($"Student Name:{items.FullName}\tStudent ID:{items.ID}\tPresenty:{items.Presenty} ");
                            }

                        break;
                        case 2:
                          
                            Console.WriteLine("Enter Name,ID and Presenty:");
                            Base student = new Base()
                            {
                                FullName = Console.ReadLine(),
                                ID = Console.ReadLine(),
                                Presenty = Console.ReadLine()
                            };
                            students.Add(student);
                            Console.Clear() ;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Student Added Successfully!");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;


                            case 3:
                            Console.WriteLine("Enter ID of student You want to remove:");
                            string Delete=Console.ReadLine();
                            foreach(Base items in students)
                            {
                                if(items.ID == Delete)
                                {
                                    students.Remove(items);
                                    Console.Clear();
                                    Console.ForegroundColor= ConsoleColor.Green;
                                    Console.WriteLine("Removed Successfully!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto here;
                                }
                            }
                            break;
      
                                
                            case 4:

                            foreach (Base items in teachers)
                            {
                                Console.WriteLine($"Teacher Name:{items.FullName}\tTeacher's ID:{items.ID}\tPresenty:{items.Presenty}");
                            }
                            break;
                            case 5:
                            Console.WriteLine("Enter Name,ID and Presenty:");
                            Base teacher = new Base()
                            {
                                FullName = Console.ReadLine(),
                                ID = Console.ReadLine(),
                                Presenty = Console.ReadLine()
                            };
                            teachers.Add(teacher);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Added Successfully!");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                            case 6:

                            Console.WriteLine("Enter ID of teacher, You want to remove:");
                            string Del = Console.ReadLine();
                            foreach (Base items in teachers)
                            {
                                if (items.ID == Del)
                                {
                                    teachers.Remove(items);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Removed Successfully!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto here;
                                } 
                            }
                            break;


                        default:

                            Console.WriteLine("Invalid Input");
                            goto Exit;



                    }
                }while(choice!=0);
                Console.Clear();

            Exit:
                Console.WriteLine("Logout Successfully!!!");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        
        
        }
    }
}
