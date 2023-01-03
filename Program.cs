namespace AttandancePortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
#nullable disable
            int choice, count = 3;
            do
            {
                Console.WriteLine("................LOGIN..............");
                Console.WriteLine("Press 1 For Admin Login\nPress 2 For Teacher Login\nPress 3 For Student Login\nPress 0 For Exit\n");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(choice)
                {
                    case 0:
                        goto Exit;
                    case 1:
                        Admin admin = new Admin();
                        admin.AdminLogin();
                        break;
                    case 2:
                        Teacher teacher = new Teacher();
                        teacher.TeacherLogin();
                        break;
                    case 3:
                        Student student= new Student();
                        student.StudentLogin();
                        break;
                   default:
                        if (count > 0)
                        {
                            Console.WriteLine("Invalid Input\nYou have {0} left trials!!!",count);
                            count--;
                        }
                        else
                        {
                            Console.WriteLine("You took maximum trials!!!");
                            goto Exit;
                        }
                   break;
                }

            }while(choice != 0);
            Exit:
            Console.WriteLine("Program Terminated!!!");
        }

       
    }
    
}