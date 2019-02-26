using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyComponents;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(args);

            if(arr.SumarArrays())
            {
                Console.WriteLine(arr.Show());
            }
            else
                Console.WriteLine("Error en el formato de entrada");
            Console.ReadKey();
        }
    }
}
