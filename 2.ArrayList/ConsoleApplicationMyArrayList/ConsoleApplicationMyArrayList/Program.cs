using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMyArrayList
{
    class PrograN
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(505);
            myList.Add(25);
            myList.Add(453);
            Console.WriteLine(myList[1]);
            Console.ReadKey();
        }
    }
}
