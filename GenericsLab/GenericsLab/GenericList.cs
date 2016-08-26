using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericsLab
{
    public class GenericList <T> : IEnumerable

    {

        public T[] internalArray; //declaring variables
        string toString;

        public GenericList()
        {
            internalArray = new T[10]; //assigning variables
        }

        public void Add (T itemToAdd) 

        {
            T[] tempInnerArray = new T[internalArray.Length + 1]; 

            for (int i = 0; i < internalArray.Length; i++)
            {
                tempInnerArray[i] = internalArray[i]; 
            }
            tempInnerArray[tempInnerArray.Length-1] = itemToAdd;
            internalArray = tempInnerArray;  
        }

        public void Remove (T item) 
        {
            T[] tempInnerArray = new T[internalArray.Length-1];
            int j = 0;
            for (int i = 0; i < internalArray.Length -1; i++)
            {

                if (EqualityComparer<T>.Default.Equals(internalArray[i], item))
                {
                    continue;
                }
                else {
                    tempInnerArray[j] = internalArray[i];
                    j++;
                }
            }
            internalArray = tempInnerArray;
        }
        public override string ToString() 
        {
            for (int i = 0; i<internalArray.Length; i++)
            {
                toString += internalArray[i].ToString();
            }
            return toString;
        }

        public IEnumerator GetEnumerator() 
        {
            for (int i = 0; i < internalArray.Length; i++)
            {
                yield return internalArray[i]; //returns contents of the array [i]
            }
        }

        public static GenericList<T> operator +(GenericList<T> list1, GenericList<T> list2) 
        {
            
            GenericList<T> resultList= new GenericList<T>();

            foreach (T item in list1)  
            {
                resultList.Add(item);
            }
            foreach(T item in list2)
            {
                resultList.Add(item);
            }
            return resultList;
        }

        public static GenericList<T> operator -(GenericList<T> list1, GenericList<T> list2)
        {

            foreach (T item in list2)
            {
                list1.Remove(item);
            }

            return list1;
        }

        public GenericList<T> Zipper(GenericList<T> list1, GenericList<T> list2)
        {
            GenericList<T> zippedResult = new GenericList<T>();
 
            for (int i = 0; i < internalArray.Length + 3; i++)

            {
                zippedResult.Add(list1.internalArray[i]);
                zippedResult.Add(list2.internalArray[i]);
            }

            return zippedResult;
        }

    }
}
