using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComponents
{
    public class MyArray
    {
        private readonly string[] args;
        private int[] result;
        private int dim_result=0;

        public MyArray(string[] p_args)
        {
            args = new string[100];
            args = p_args;
        }
        public bool SumarArrays()
        {            
            result = new int[100];
            
            List<int> cont_numeros = new List<int>();
            foreach (string arg in args)
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
    }
}
