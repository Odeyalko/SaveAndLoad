using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAndLoadSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            DataList d = new DataList();
            d.Add("Rob", 31, "Programmer");
            d.Add("Get", 31, "Modeller");
            d.Add("Freeman", 31, "Httpator");
            d.Add("Robinson", 31, "humanizator");
            d.PrintList();


            Console.ReadKey();
        }
    }
}
