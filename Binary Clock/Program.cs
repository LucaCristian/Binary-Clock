using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Clock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Binary Clock");
            Console.Write("\n");

            Console.Write(Convert.ToString(System.DateTime.Now.Hour, 2));
            Console.Write(":");

            Console.Write(Convert.ToString(System.DateTime.Now.Minute, 2));
            Console.Write(":");

            Console.Write(Convert.ToString(System.DateTime.Now.Second, 2));

            Console.ReadKey();
        }
    }
}