using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void PrintRez(int x, int y, char sign)
        {
            switch (sign)
            {
                case '+':
                    Console.WriteLine(x+y);
                    break;
                case '-':
                    Console.WriteLine(x - y);
                    break;
                case '*':
                    Console.WriteLine(x * y);
                    break;
                case '/':
                    if (y==0)
                    {
                        Console.WriteLine("Devide by zero exception!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(x / y);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong sign");
                    break;
                    
            }
       /* static void PrintRez(int x, char sign, int y) // сигнатура метода
        {
            if (sign == '-')
            {
                Console.WriteLine(x-y);
            }
            else if (sign == '+')
            {
                Console.WriteLine(x+y);
            }
            else if (sign == '/')
            {
                Console.WriteLine(x/y);
            }
            else if (sign == '*')
            {
                Console.WriteLine(x*y);
            }*/

        }

        static void Main(string[] args)
        {
            //1
            /* int[] array = { 10, 1, 1, 3, 4, 10, 6, 7, 7, 10 };

             List<int> distinctList = new List<int>();
             distinctList.Add(array[0]);
             bool IsInList = false;

             for (int i = 1; i < array.Length; i++)
             {
                 IsInList = false;
                 foreach (var item in distinctList)
                 {
                     if(array[i] == item)
                     {
                         IsInList = true;
                         break;
                     }
                 }

                 if (IsInList)
                 {
                     continue;
                 }
                 else
                 {
                     distinctList.Add(array[i]);
                 }
             }

             foreach (var item in distinctList)
             {
                 Console.WriteLine(item);
             }*/

            //2

            /* int[] array = { 10, 1, 2, 3, 5, 4, 6, 9, 7, 0 };
             int a;

             for (int i = 0; i < array.Length; i++)
             {
                 for (int j = 1; j < array.Length - i; j++)
                 {
                     if (array[j-1] > array[j])
                     {
                         a = array[j-1];
                         array[j - 1] = array[j];
                         array[j] = a;

                     }
                 }

             }
             foreach (var item in array)
             {
                 Console.WriteLine(item);
             }*/

            //ClassWork

            /*int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());*/
            string str = Console.ReadLine(); //x-y
            char sign = Convert.ToChar(str[1]);

            int x = int.Parse(str[0].ToString());
            int y = int.Parse(str[str.Length - 1].ToString());

            PrintRez(x, y, sign);




        }
    }
}
