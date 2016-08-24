using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericsLab
{
    public class GenericList <T>/*: IEnumerable*/ 

    {

        private T[] internalArray; //declaring variables
        private T[] internalArrayTwo;
        string toString;

        public GenericList()
        {
            internalArray = new T[0]; //assigning variables
            internalArrayTwo = new T[0];
        }

        public void Add (T itemToAdd) //Tested and verified by A.Amini-Hajibashi on 8/24/2016
        {
            T[] tempInnerArray = new T[internalArray.Length + 1]; 

            for (int i = 0; i < internalArray.Length; i++)
            {
                tempInnerArray[i] = internalArray[i]; 
            }
            tempInnerArray[tempInnerArray.Length-1] = itemToAdd;
            internalArray = tempInnerArray;
            
        }

        public void Subtract () //Tested and Verified by A.Amini-Hajibashi on 8/24/2016
        {
            T[] tempInnerArrayTwo = new T[internalArray.Length - 1];
            for (int i = 0; i < internalArray.Length -1 ; i ++)
            {
                tempInnerArrayTwo[i] = internalArray[i];
            }
            
            internalArray = tempInnerArrayTwo;
        }

        public string ConvertToString() //Tested and Verified by A.Amini-Hajibashi on 8/24/2016
        {
            for (int i = 0; i<internalArray.Length; i++)
            {
                toString += internalArray[i].ToString();
            }
            return toString;
        }


        //public IEnumerator GetEnumerator()
        //{
        //    for (int i = 0; i <internalArray.Count; i++)
        //    {
        //        yield return "";
        //        yield return "";
        //        yield return "";
        //        yield return "";
        //        yield return "";
        //    }
        //    yield return "The End";
        //}

    }
}
