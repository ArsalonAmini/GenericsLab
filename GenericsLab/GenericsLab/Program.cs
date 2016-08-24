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
            genericListInt.Subtract();
            genericListInt.ConvertToString();
            
            
            Console.ReadLine();

            //foreach (var name in genericListInt)
            //{
            //    Console.WriteLine();
            //}
            //Console.ReadLine();



            //TestClass <int> testclass = new TestClass <int>();
            //testclass.RunTest();
        }

    }
}
