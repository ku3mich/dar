using System.Collections.Generic;

namespace dar
{
    public class StackDar3 : IDar
    {
        public int GetDominantIndex(int[] ar)
        {
            var stack = new Stack<int>();
            foreach (var a in ar)
            {
                if (stack.Count > 0 && stack.Peek() != a)
                    stack.Pop();
                else
                    stack.Push(a);
            }

            if (stack.Count == 0)
                return -1;

            var candidate = stack.Pop();
            int count = 0;
            var half = ar.Length / 2;
            for (var i = 0; i < ar.Length; i++)
            {
                if (candidate == ar[i] && ++count > half)
                    return i;
            }

            return -1;
        }
    }
}