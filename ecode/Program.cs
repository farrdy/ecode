using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            AddNumbers();
            Console.ReadLine();

        }
        static void  AddNumbers() {
            var number1 = 10;
            var number2 = 100;
            Console.WriteLine("number1=" + number1);
            Console.WriteLine("number2=" + number2);
           
        }
    }
}
