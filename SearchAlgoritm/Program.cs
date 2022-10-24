﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgoritm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //number of elements in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("array should have minimum 1 and maximum 20 elemets.");
            }
            //accept array elements
            Console.WriteLine("");
            Console.WriteLine("=======================");
            Console.WriteLine("enter array elements : ");
            Console.WriteLine("=======================");
            for (i=0;i<n;i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searched
                Console.Write("\nenter elements want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item! = arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1));
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.Write("\ncontinue search (y/n) : ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'y'));
        }

        public void LinearSearch()
        {
            char ch;
            //search for number of comparison
            int ctr;
            do
            {
                //accept the number to be searched
                Console.Write("\nenter elements want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + "found at position" + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + " not found in the array");
                Console.WriteLine("number of comparison : " + ctr);
                Console.Write("\ncontinue search (y/n : ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'y'));
        }
        static void Main(string[] args)
        {
            Program mylist = new Program();
            int pilihanmenu;
            do
            {
                Console.WriteLine("menu option");
            }
        }
    }
}
