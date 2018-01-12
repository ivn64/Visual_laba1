using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Visual_laba1
{
    class MyString
    {
        private string stroka = "";
        public int N { get; set; } = 4;
        string[] arr = new string[500];

        public MyString()
        {
            do
            {
                Console.WriteLine("Введите строку");
                stroka = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(stroka) != false);
        }

        public void SearchWorlds()
        {
            string[] arr = new string[50];
            int k = 0;
            int n = stroka.Length;
            StringBuilder t = new StringBuilder();
            int kol = 0;
            for (int i = 0; i < n; i++)
            {
                if (stroka[i] != ' ' && i != n - 1)
                    kol++;
                else
                {
                    if (kol == N)
                    {
                        for (int m = N; m != 0; m--)
                            t.Append(stroka[i - m]);
                        arr[k] = t.ToString();
                        k++;
                        t.Clear();
                    }
                    if (kol == N - 1 && i == n - 1)
                    {
                        for (int m = N - 1; m != 0; m--)
                            t.Append(stroka[i - m]);
                        t.Append(stroka[i]);
                        arr[k] = t.ToString();
                        k++;
                        t.Clear();
                    }
                    kol = 0;
                }
            }
            Array.Sort(arr);
            foreach (string yy in arr)
            {
                if (yy!=null)
                    Console.WriteLine(yy);
            }
        }       
    }
}
