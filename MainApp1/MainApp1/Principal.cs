using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp1
{
    public class Principal
    {
        public char Secname { get; private set; }
        public string Strength { get; set; }

        public void AddClass()
        {
            Console.WriteLine("Enter the section name");
            Secname = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter strength");
            Strength = Console.ReadLine();
        }
        public void DisplayClass()
        {
            Console.WriteLine("section is:\t" + Secname);
            Console.WriteLine("Strength:\t" + Strength);
        }
    }
}
    
