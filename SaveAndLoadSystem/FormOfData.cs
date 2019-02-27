using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAndLoadSystem
{
    class FormOfData
    {
        string name;
        int age;
        string job;
      
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public FormOfData(){}
        public FormOfData( string _name, int _age, string _job)
        {
            name = _name;
            age = _age;
            job = _job;
        }

        public override string ToString()
        {
            return name + "\n" + age + "\n" + job + "\n";
        }
    }
}
