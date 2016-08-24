using GenericsLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    class Program 
    {
        static void Main(string[] args)
        {

            
            GenericList<int> genericListInt = new GenericList<int>();
            genericListInt.Add(5);
            genericListInt.Add(10);
            genericListInt.Add(15);
            Console.ReadLine();


            //TestClass <int> testclass = new TestClass <int>();
            //testclass.RunTest();

            //IterableClass iterable = new IterableClass();
            //foreach (var name in iterable)
            //{
            //    //method
            //}
            //Console.ReadLine();
        }

    }
}
