using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundacion.Jala.Dev27.OscarCortez;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ManagerData managerData = new ManagerData(args);
            List<List<int>> convertedData = managerData.ConvertToListOfList();
                        
            Vector vector1 = new Vector(convertedData.ElementAt(0));
            Vector vector2 = new Vector(convertedData.ElementAt(1));

            Vector resultSum = vector1.Sum(vector2);
            int resultDotProduct = vector1.DotProduct(vector2);
            double resultLength = vector1.Length();
            managerData.ShowData(convertedData);

            
            Console.WriteLine(resultSum.Show());
            Console.WriteLine(resultDotProduct.ToString());
            Console.WriteLine(resultLength.ToString());

            Console.ReadKey();
        }
    }
}
