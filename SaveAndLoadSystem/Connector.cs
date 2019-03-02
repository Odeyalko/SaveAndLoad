using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SaveAndLoadSystem
{
    /*Класс выполняет соединение с базой и записывает/читает из нее*/

    class ConnectorTxt
    {
        string path = "db.mur";

        public void Writer(string record)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(record);
            sw.Close();
        }

        public string Reader()
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
            
        }

        
    }
}
