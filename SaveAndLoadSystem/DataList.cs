using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAndLoadSystem
{
    class DataList
    {
        ConnectorTxt connector = new ConnectorTxt();

        List<FormOfData> workers;

        public DataList()
        {
            workers = new List<FormOfData>();
        }

        public void Add(string name, int age, string job)//Добавляет в коллекцию объект
        {
            workers.Add(new FormOfData(name, age, job));
        }
        
        public string GetList()//возвращает строку со всеми данными из коллекции
        {
            string print = null; 
            foreach (var e in workers)
            {
                print = print + e.ToString(); 
            }
            return print;
            
        }
        
        public string GiveWithIndex(int index)//возвращает строку с одним работником 
        {
            return workers[index].ToString();
        }

        public void Save()//сохранение в файл
        {
            connector.Writer(GetList());
        }


    }
}
