using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();
            arr.ArrayInput();
            arr.ArrayOutput();
            arr.MaxFromMinElement();

            MyString stroka = new MyString();
            stroka.SearchWorlds();
            
            Console.ReadKey();
        }
    }
}
