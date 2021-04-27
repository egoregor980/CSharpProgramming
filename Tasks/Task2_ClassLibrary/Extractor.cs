using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task2_ClassLibrary
{
    public class Extractor
    {
        public string OutputT { get; set; }
        public string OutputN { get; set; }

        public Extractor()
        {

        }

        public void Extract()
        {
            var T = File.ReadAllLines(OutputT);
            var N = File.ReadAllLines(OutputN);
            for (int i = 0; i < T.Length && i < N.Length; i++)
            {
                T[i] = N[i] + T[i] + N[i];
            }
            File.WriteAllLines(this.OutputT, T);
        }
    }
}
