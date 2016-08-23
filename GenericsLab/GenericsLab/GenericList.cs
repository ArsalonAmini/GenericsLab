using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    public class GenericList<T>

    {

        private T[] internalArray;
        private T[] internalArrayTwo;
 
        //innerArray = new T[0] //creating an internal array

        public void AddToList()
        {
            internalArray = new T[0];
            internalArrayTwo = new T[0];
        }
        public void AddObjectToList(string cat) //Method
        {
            T[] tempInnerArray = new T[internalArray.Length + 1]; //creating a new array

            for (int i = 0; i < internalArray.Length; i++)
            {
                tempInnerArray[i] = internalArray[i]; //passing in values from old array to new array
            }
            internalArray = tempInnerArray;
        }

        public void RemoveFromList() //method
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
