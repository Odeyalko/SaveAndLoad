using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAndLoadSystem
{
    class DataList
    {
        List<FormOfData> workers;

        public DataList()
        {
            workers = new List<FormOfData>();
        }

        public void Add(string name, int age, string job)
        {
            workers.Add(new FormOfData(name, age, job));
        }

        public void PrintList()
        {
            foreach (var e in workers)
            {
                Console.WriteLine(e.ToString()); 
            }
            
        }
        
    }
}
