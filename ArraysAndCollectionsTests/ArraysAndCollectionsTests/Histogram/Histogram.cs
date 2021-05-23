using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    public class Histogram
    {
        private const string Path = "midtermscores.txt";

        public static string HistogramMaker()
        {
            var readText = File.ReadAllLines(Path);

            var stringOfScores = String.Concat(readText);
            var scoreArray = stringOfScores.Split(' ');
            var x = new Dictionary<int, string>
            {
                {1, "00-09: "},
                {2, "10-19: "},
                {3, "20-29: "},
                {4, "30-39: "},
                {5, "40-49: "},
                {6, "50-59: "},
                {7, "60-69: "},
                {8, "70-79: "},
                {9, "80-89: "},
                {10, "90-99: "},
                {11, "  100: "}
            };

            foreach (var c in scoreArray)
            {
                var n = int.Parse(c);
                if (n < 10)
                {
                    x[1] += "*";
                }

                else if (n < 20 && n >= 10)
                {
                    x[2] += "*";
                }

                else if (n < 30 && n >= 20)
                {
                    x[3] += "*";
                }

                else if (n < 40 && n >= 30)
                {
                    x[4] += "*";
                }

                else if (n < 50 && n >= 40)
                {
                    x[5] += "*";
                }

                else if (n < 60 && n >= 50)
                {
                    x[6] += "*";
                }

                else if (n < 70 && n >= 60)
                {
                    x[7] += "*";
                }

                else if (n < 80 && n >= 70)
                {
                    x[8] += "*";
                }

                else if (n < 90 && n >= 80)
                {
                    x[9] += "*";
                }

                else if (n < 100 && n >= 90)
                {
                    x[10] += "*";
                }

                else if (n == 100)
                {
                    x[11] += "*";
                }
            }

            var output = x.Aggregate("", (current, c) => current + (c.Value + "\n"));
            return output.TrimEnd();
        }
    }
}