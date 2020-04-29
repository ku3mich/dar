using System.Collections.Generic;

namespace dar
{
    public class StackDar : IDar
    {
        public int GetDominantIndex(int[] ar)
        {
            var stack = new Stack<int>();
            foreach (var a in ar)
            {
                if (stack.Count > 0 && stack.Peek() != a)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(a);
                }
            }

            if (stack.Count == 0)
            {
                return -1;
            }
            else
            {
                var candidate = stack.Pop();
                int count = 0;
                foreach (var a in ar)
                {
                    if (candidate == a)
                    {
                        count++;
                    }
                }
                if (count <= ar.Length / 2)
                {
                    return -1;
                }

                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] == candidate)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }

}
