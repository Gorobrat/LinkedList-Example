using LinkedListExample.Models2;
using LinkedListExample.Models3;
using System;
namespace LinkedListExample
{


    class Program
    {
        static void Main()
        {
            var list = new Models.LinkedList<int>();
            list.Add(8);
            list.Add(77);
            list.Add(15);
            list.Add(12);
            list.Add(25);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Delete(15);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendHead(7);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(12,88);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();


            Console.WriteLine(new string ('-',10));

            // new other example 

            var list2=new DuplexLinkedList<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);

            foreach (var item in list2) 
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine(new string('*', 10));
            list2.Delete(3);

            foreach (var item in list2)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine(new string('*', 10));
            var reverse=list2.Reverse();

            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }

            //
            // other example circularList 


            Console.WriteLine(new string ('+',10));

            var circularList=new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
        }
    }
}