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

            foreach (var item in genericListInt) //Tested and verified by A.Amini-Hajibashi
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



            //TestClass <int> testclass = new TestClass <int>();
            //testclass.RunTest();
        }

    }
}
