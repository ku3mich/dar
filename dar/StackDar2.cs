using System.Collections.Generic;

namespace dar
{
    public class StackDar2 : IDar
    {
        public int GetDominantIndex(int[] ar)
        {
            var stack = new Stack<(int a, int i)>();
            for (var i = 0; i < ar.Length; i++)
            {
                var a = ar[i];
                if (stack.Count > 0 && stack.Peek().a != a)
                    stack.Pop();
                else
                    stack.Push((a, i));
            }

            if (stack.Count == 0)
                return -1;

            var candidate = stack.Pop();
            var c = 0;
            for (var i = 0; i < ar.Length; i++)
            {
                if (ar[i] == candidate.a)
                    c++;
            }

            return c > ar.Length / 2 ? candidate.i : -1;
        }
    }
}
