using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("3"); // Adding a non-integer element (a string)
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add("seven"); // Adding a non-integer element (a string)
            arrayList.Add(8);
            arrayList.Add(9);
            arrayList.Add(10);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("------------------");

            int elementToRemove = 5;
            arrayList.Remove(elementToRemove);
            {
                foreach(var item in arrayList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------");
            }

            int[] array = new int[arrayList.Count];

            arrayList.CopyTo(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            ArrayList intElements = new ArrayList();
            foreach (var element in arrayList)
         
                if (element is int)
                {
                    intElements.Add(element);
                }


            foreach (var item in intElements)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("===================");

            intElements.Sort();
            foreach (var item in intElements)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==============");

            intElements.Reverse();

            foreach(var item in intElements)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
