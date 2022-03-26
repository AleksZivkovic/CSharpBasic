using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region strArray
            string[] strArray = new string [4];
            string[] strArray2 = new string[] { "Hello", "World" };
            GoThruCollection (strArray2, "Array");
            #endregion strArray

            #region Array
            Array.Resize(ref strArray2, strArray2.Length + 1);
            strArray2[strArray2.Length - 1] = "!";
            GoThruCollection(strArray2, "Array");
            #endregion Array    

            #region List
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(9);
            numbers.Add(3);
            numbers.Remove(9);
            Console.WriteLine("List count is: " + numbers.Count);
            GoThruCollection(numbers, "List of integer");
            #endregion List

            #region Stack and Queue 

            Console.WriteLine("===================QUEUE===================");
            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25);
            someQueue.Enqueue(2);
            someQueue.Enqueue(3);
            someQueue.Enqueue(111);


            int firstElement = someQueue.Dequeue();
            Console.WriteLine(firstElement);
            GoThruCollection(someQueue, "Queue");
            //Console.WriteLine(someQueue[2]); // we cannot use indexes
            Console.WriteLine(someQueue.Peek());
            Console.WriteLine("Length: " + someQueue.Count);


            Console.WriteLine("========================STACk=====================");

            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hey");
            someStack.Push("Hello");
            someStack.Push("Hi");
            someStack.Push("Zdravo");

            string item = someStack.Pop();
            Console.WriteLine("POP: " + item);
            Console.WriteLine("Peek: " + someStack.Peek());
            Console.WriteLine("Length: " + someStack.Count);

            
            GoThruCollection(someStack, "STACK");

            #endregion







            Console.ReadLine();
        }



        public static void GoThruCollection(IEnumerable collection, string name)
        {
            Console.WriteLine("Collection {0} items", name);
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine();
        }
    }
}
