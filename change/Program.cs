﻿using System;
using System.Linq;

namespace change
{
    public class Program
    {

        public static int[] exchange(int input)
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
        }

        public static int[] what(int dd)
        {
            int[] a = new int[0];
            if (dd % 2 == 1)
            {
                var x = dd / 2;
                a = new int[2];
                a[0] = x;
                a[1] = x + 1;
            }
            else if (dd % 3 == 0)
            {
                var x = dd / 3;
                a = new int[3];
                a[0] = x - 1;
                a[1] = x;
                a[2] = x + 1;
            }
            else if (dd % 4 == 2)
            {
                var x = dd / 4;
                a = new int[4];
                a[0] = x - 1;
                a[1] = x;
                a[2] = x + 1;
                a[3] = x + 2;
            }
            else if (dd % 5 == 0)
            {
                var x = dd / 4;
                a = new int[5];
                a[0] = x - 2;
                a[1] = x - 1;
                a[2] = x;
                a[3] = x + 1;
                a[4] = x + 2;
            }
            return a;
        }

        static void Main(string[] args)
        {
            var a = what(int.Parse(Console.ReadLine()));
            foreach (var item in a)
            {
               Console.WriteLine(item); 
            }            
        }
    }
}
