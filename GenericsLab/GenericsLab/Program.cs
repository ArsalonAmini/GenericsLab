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

            
            GenericList<int> list1 = new GenericList<int>(); //generate list one
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);
            list1.Subtract();
            list1.ConvertToString();

            GenericList<int> list2 = new GenericList<int>(); //generate list two
            list2.Add(4);
            list2.Add(3);
            list2.Add(5);
            list2.Add(1);
            list2.Subtract();
            list2.ConvertToString();

            GenericList<int> CombineList = list1 + list2; //calling + operator overide



            foreach (var item in list1) //display list one items
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

           

        }

    }
}
