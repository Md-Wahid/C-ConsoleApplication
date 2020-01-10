using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("name1", 500);
            dic.Add("name2", 400);
            dic.Add("name3", 900);

            Console.WriteLine("Pair:");
            foreach (KeyValuePair<string, int> var in dic)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine();

            Console.WriteLine("Keys:");
            foreach (KeyValuePair<string, int> var in dic)
            {
                Console.WriteLine(var.Key);
            }
            Console.WriteLine();

            Console.WriteLine("Values:");
            foreach (KeyValuePair<string, int> var in dic)
            {
                Console.WriteLine(var.Value);
            }
            Console.ReadKey();

        }
    }
}
