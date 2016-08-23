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

            //TestClass <int> testclass = new TestClass <int>();
            //testclass.RunTest();
            GenericList<int> genericList = new GenericList<int>();
            genericList.AddObjectToList("cat");

            IterableClass iterable = new IterableClass();
            iterable.GetEnumerator();
        }

    }
}
