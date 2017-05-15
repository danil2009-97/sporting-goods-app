using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sporting_goods_App
{
    class Logger
    {
        public void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter("../../Archive/Changes.txt", true))
                sw.WriteLine($"{DateTime.Now} - {message}");
        }
    }
}
