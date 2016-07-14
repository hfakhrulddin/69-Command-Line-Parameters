using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[] { "I am 1st", "I am 2nd", "I am 3rd"}; 

            Console.WriteLine("Number of command line parameters = {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
            Console.ReadLine();
        }
    }
}
