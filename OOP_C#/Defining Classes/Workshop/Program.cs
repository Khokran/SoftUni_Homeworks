using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Workshop_LAB;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var scale = new Equality_Scale<int>(5, 5);
            Console.WriteLine(scale.AreEqual());
            scale.WhichIsHavier();

            //Test1();
            //Test2();


            //var list = new CustomList();
            //var list2 = new CustomList(50);

            //list.Add(7);
            //list.Add(12);
            //list.Add(23);

            //list.AddRange(new int[] { 7, 34, 56, 12, 89, 65, 34, 2 });
            //list.RemoveAt(3);
            //list.InsertAt(1456,90);
            //list.InsertAt(4, 8);
            //list.Swap(0, 8);

            //list.ForEach(Console.WriteLine);
            //var st = new CustomStack();
            //st.Push(6);
            //st.Push(8);
            //st.Push(78);
            //st.Push(3);

            //var x = st.Pop();
            //st.Push(777);
            //st.Push(123);
            //x = st.Peek();


            //st.ForEach(Console.WriteLine);


        //}
        //public static void Test1()
        //{
        //    ClassStatic.Name = "Pesho";
        //}
        //public static void Test2()
        //{
        //    Console.WriteLine(ClassStatic.Name);
        }
    }
}
