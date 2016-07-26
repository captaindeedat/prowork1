using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prowork1
{
    class Program
    {
        static void Main(string[] args)
        {           
            int num, sum;
            string str, newvalue;
            List<string> mystring = new List<string>();
           
            num = Int32.Parse(Console.ReadLine());

            for (int k = 1; k <= num; k++)
            {                
                str = Console.ReadLine();
                mystring.Add(str);
            }
            foreach (string dstring in mystring)
            {
                newvalue = Remove(dstring);
                sum = newvalue.Length;
                Console.WriteLine(sum);
            }
            Console.ReadLine();
           
        }
        // The method below removes duplicates from the input string and returns a non-duplicate string as output
        static string Remove(string key)
        {           
            string result = "";

            foreach (char value in key)
            {
                if (result.IndexOf(value) == -1)
                {
                    result += value;
                    
                }
            }
            return result;
        }
    }
}
