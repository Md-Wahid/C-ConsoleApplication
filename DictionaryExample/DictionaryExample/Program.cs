using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> salary = new Dictionary<string, double>();
            salary.Add("Sumon", 300);
            salary.Add("Masum", 400);
            foreach(KeyValuePair<string, double> sal in salary)
            {
                Console.WriteLine(sal.Key +" "+ sal.Value + "$");
            }
            Console.ReadKey();
        }
    }
}
