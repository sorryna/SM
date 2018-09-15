using System;

namespace change
{
    public class Program
    {

        public int[] exchange(int input)
        {
            int[] t = new int[9];
            int[] Banknotes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            for (int i = 0; i < Banknotes.Length; i++)
            {
                if (input >= Banknotes[i])
                {
                    t[i] = input / Banknotes[i];
                    //Console.WriteLine("Banknotes 1000 :" + t);
                    input = input % Banknotes[i];
                    // input = f;
                    // Console.WriteLine(t[i]); 
                }
            }
            return t;

            // if (input >= 1000)
            // {
            //     t = input / 1000;
            //     Console.WriteLine("Banknotes 1000 :" + t);
            //     input = input % 1000;
            // }
            // if (input >= 500)
            // {
            //     t = input / 500;
            //     Console.WriteLine("Banknotes 500 :" + t);
            //     input = input % 500;
            // }
            // if (input >= 100)
            // {
            //     t = input / 100;
            //     Console.WriteLine("Banknotes 100 :" + t);
            //     input = input % 100;
            // }
            // if (input >= 50)
            // {
            //     t = input / 50;
            //     Console.WriteLine("Banknotes 50 :" + t);
            //     input = input % 50;
            // }
            // if (input >= 20)
            // {
            //     t = input / 20;
            //     Console.WriteLine("Banknotes 20 :" + t);
            //     input = input % 20;
            // }
            // if (input >= 10)
            // {
            //     t = input / 10;
            //     Console.WriteLine("Banknotes 10 :" + t);
            //     input = input % 10;
            // }
            // if (input >= 5)
            // {
            //     t = input / 5;
            //     Console.WriteLine("Banknotes 5 :" + t);
            //     input = input % 5;
            // }
            // if (input >= 2)
            // {
            //     t = input / 2;
            //     Console.WriteLine("Banknotes 2 :" + t);
            //     input = input % 2;
            // }
            // if (input >= 1)
            // {
            //     t = input / 1;
            //     Console.WriteLine("Banknotes 1 :" + t);
            //     input = input % 1;
            // }

            // return t;
        }

        static void Main(string[] args)
        {
            // var a = change(int.Parse(Console.ReadLine()));
            // foreach (var item in a)
            // {
            //    Console.WriteLine(item); 
            // }            
        }
    }
}
