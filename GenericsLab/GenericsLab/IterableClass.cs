﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{ 
    public class IterableClass /*: IEnumerable <T>*/
{
    
    int iterationCount;

    public IterableClass()
    {
       
        iterationCount = 0;
    }

    //public IEnumerator GetEnumerator()
    //{
    //    for (int i = 0; i < .Count; i++)
    //    {
    //        yield return 1;
    //        yield return 2;
    //        yield return 3;
    //        yield return 4;
    //        yield return 5;
    //    }
    //    yield return "The End";
    //}

    }
}
