using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundacion.Jala.Dev27.OscarCortez
{
    
    public class ManagerData
    {
        private const string InvalidArgumentsMessage = "Vector Arguments are not valid, the correct Format is x1,y2 x2,y2";
        private const string InvalidNumberMessage = "Vector Arguments must supply valid numbers.";
        private readonly string[] inputsData;
        private int[] result;
        private int dim_result=0;

        public ManagerData(string[] inputData)
        {
            inputsData = new string[100];
            inputsData = inputData;
        }
        public bool SumarArrays()
        {            
            result = new int[100];
            
            List<int> cont_numeros = new List<int>();
            foreach (string arg in inputsData)
            {
                int i = 0;
                StringBuilder sb_args = new StringBuilder(arg);
                string[] arr_args =  sb_args.ToString().Split(Convert.ToChar(","));
                cont_numeros.Add(arr_args.Length);
                dim_result = arr_args.Length;
                foreach(string arr_arg in arr_args)
                {                    
                    if (Int32.TryParse(arr_arg, out int int_validated))
                    {                       
                        result[i] += int_validated;
                        i++;
                    }
                    else
                    {
                        return false;
                    }
                }                
            }
            var first_elem = cont_numeros.First();
            foreach(int cn in cont_numeros)
            {
                if (first_elem != cn)
                    return false;
            }
            return true;
        }

        public List<List<int>> ConvertToListOfList ()
        {
            List<List<int>> result = new List<List<int>>();
            List<int> coordinatesLength = new List<int>();
            foreach (string inputData in inputsData)
            {
                List<int> subResult = new List<int>();
                StringBuilder coordinate = new StringBuilder(inputData);
                string[] coordinateNumber = coordinate.ToString().Split(Convert.ToChar(","));
                coordinatesLength.Add(coordinateNumber.Length);
                dim_result = coordinateNumber.Length;
                foreach (string arr_arg in coordinateNumber)
                {
                    if (int.TryParse(arr_arg, out int validatedNumber))
                    {
                        subResult.Add(validatedNumber);
                    }
                    else
                    {
                        throw new ArgumentException(InvalidNumberMessage);
                    }
                }
                result.Add(subResult);
            }
            if(coordinatesLength.Count != 2)
            {
                throw new ArgumentException(InvalidArgumentsMessage);
            }
            var firstCoordinateLength = coordinatesLength.First();
            foreach (int coordinateLength in coordinatesLength)
            {
                if (firstCoordinateLength != coordinateLength)
                    throw new ArgumentException(InvalidArgumentsMessage);
            }            
            return result;
        }

        public string Show()
        {
            StringBuilder str_result = new StringBuilder();
            foreach (int res in result)
            {
                if (res != 0)
                {
                    str_result.Append(res);
                    str_result.Append(",");
                }
                else
                    break;
            }
            return str_result.ToString().Substring(0,str_result.Length -1);
        }
        public void ShowData(List<List<int>> results)
        {
            foreach (List<int> result in results)
            {
                foreach (int number in result)
                {
                    Console.Write($"{number.ToString()} ");
                }
                Console.WriteLine();
            }
        }
    }
}
