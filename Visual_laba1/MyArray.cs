using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_laba1
{
    public class MyArray
    {
        private const int lines = 5;
        private const int colums = 5;
        private int[,] array = new int[lines, colums]; //{ { 6, 0, 10, 5, 17 }, { 3, 0, 1, 7, 16 },{ 2, 8, 17, 12, 3 },{ 11, 3, 18, 14, 1 },{ 5, 16, 7, 5, 8 } };

        public void ArrayInput()
        {
            Random rand = new Random();
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array[i, j] = rand.Next(20);
                }
            }
        }

        public void MaxFromMinElement()
        {
            int[] min = new int[lines];
            int k = 0;
            int max = -100;
            int temp = 0;
            int lineOfMax = 0, columnOfMax = 0;
            for (int i = 0, j = 0; i < lines; i++)
            {
                min[k] = 100;
                for (j = 0; j < colums; j++)
                {
                    if (array[i, j] < min[k])
                    {
                        temp = j;
                        min[k] = array[i, j];
                    }
                }
                if (max < min[k])
                {
                    max = min[k];
                    lineOfMax = k + 1;
                    columnOfMax = temp + 1;
                }
                k++;
            }
            Console.WriteLine("max {0}, line {1}, column {2}", min.Max(), lineOfMax, columnOfMax);
        }

        public void ArrayOutput()
        {
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write("{0}\t",array[i, j]);          
                }
                Console.WriteLine();
            }
        }
    }
}
