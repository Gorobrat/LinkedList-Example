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
        }
    }
}