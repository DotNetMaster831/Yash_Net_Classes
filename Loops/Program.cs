using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for
            //do while
            //while
            //Foreach

            #region print even numbers in list for loop

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

            for (int i = 0; i < list.Count; i++)
            {
                int val1 = 20;

                if (list[i] % 2 == 0)
                {

                    if (list[i] == 8)
                    {
                        continue;
                    }
                    else if (list[i] == 10)
                        break;
                    Console.Write(list[i]);
                    Console.Write(" ");

                }


                //Console.Write(list[i]);
                Console.Write(" ");
            }

            //Console.ReadKey();

            #endregion

            #region  Enter a number and print the Fibonacci series using while loop

            //int x = 1;
            //while (x <= 5)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            //0 1 1 2 3 5 8 .....



            //int i, j, k, n;
            //Console.WriteLine("Enter the number");

            //n = Convert.ToInt32(Console.ReadLine());

            //i = 0;
            //j = 1;
            ////Console.WriteLine("values are" + i);
            //Console.Write($"values are {i} {j}");

            //k = i + j;

            //while(k <= n)
            //{
            //    Console.Write($"{k}\t");
            //    i = j;
            //    j = k;
            //    k = i + j;
            //}




            //Console.ReadKey();

            #endregion

            #region Do while
            int number = 1;
            //do 
            //{
            //    Console.WriteLine(number); number++;
            //} while (number < 1);

            #endregion



            #region foreach loop
            foreach(int num in list)
            {

                Console.WriteLine(num);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
