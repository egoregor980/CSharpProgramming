using System;
using System.Linq;

namespace Task1_ClassLibrary
{
    public class Task1Solver
    {
        private int[][] array;

        public Task1Solver(int[][] array)
        {
            this.array = array;
        }
        public int[][] DoSolve()
        {
            return new int[][] { new int[]{ array.Select(x => CheckSequence(x)).Where(x => x).Count() } };
        }

        private bool CheckSequence(int[] x)
        {
            if (x.Length < 2)
            {
                return true;
            }
            var f = x.First();
            var inc = true;
            var dec = true;
            foreach (var fe in x.Skip(1))
            {
                if (fe > f)
                {
                    dec = false;
                }
                if (fe < f)
                {
                    inc = false;
                }
                f = fe;
            }
            return inc || dec;
        }
    }
}
