using System;
using MySharedLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MainApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation you want to perform");
            Console.WriteLine("1.Add student 2.Add class");
            int op = int.Parse(Console.ReadLine());
            Students obj = new Students();
            Principal school = new Principal();
            switch (op)
            {
                case 1:
                    {
                        obj.AddStudent();
                        obj.Display();
                        break;
                    }
                case 2:
                    {
                        school.AddClass();
                        school.DisplayClass();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
        
    
