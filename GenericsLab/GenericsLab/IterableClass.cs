using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{ 
class IterableClass : IEnumerable
{
    
    int iterationCount;

    public IterableClass()
    {
       
        iterationCount = 0;
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < .Count; i++)
        {
            yield return ;
            yield return ;
            yield return ;
            yield return ;
            yield return ;
        }
        yield return "The End";
    }

}
}
