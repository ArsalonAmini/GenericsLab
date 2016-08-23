using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    class IterableClass
    {
        List<T> name;
        List<T> variable;
        int iterationCount;

        public IterableClass()
        {
            name = new List<string>() { "value", "Value", "Value" };
            variable = new List<int>() { 1, 2, 2 };
            iterationCount = 0;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < name.Count; i++)
            {
                yield return 5;
                yield return name[i];
                yield return "";
                yield return variable[i];
                yield return "/n";
            }
            yield return "That's it boss";
        }

    }
}
