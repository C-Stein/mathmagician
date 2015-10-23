using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class NaturalNumbers
    {
        protected int first;

        public NaturalNumbers()
        {
// your're able to set defaults in the constsructor
            first = 1;
        }

        public virtual int GetNext(int x)
        {
            return x + 1;
        }

        public int GetFirst()
        {
            return first;
        }
        public int[] GetSequence()
        {
            return GetSequence(10);
        }
        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }
        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            /*for(int i = 0; i < array.Length; i++)
            {
                output += array[i].ToString() + " ";
            }
            */
            return output;
        }
    }
}
