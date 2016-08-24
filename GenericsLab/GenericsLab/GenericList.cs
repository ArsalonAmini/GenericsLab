using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    public class GenericList<T>

    {

        private T[] internalArray; //declaring variables
        private T[] internalArrayTwo;
 
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

        public void Subtract (T itemToSubtract) //method
        {
            T[] tempInnerArrayTwo = new T[internalArray.Length - 1];
            for (int i = 0; i < internalArray.Length; i ++)
            {
                tempInnerArrayTwo[i] = internalArray[i];
            }
            internalArray = tempInnerArrayTwo;
        }

        public void ConvertToString () //method for converting custom array to a string 
        {

        }

    }
}
