namespace CozaWozaLoza
{
    public class CozaWozaLoza
    {
        public static string CozaWozaLozaString(int number)
        {
            var result = "";
            for (var i = 1; i <= number; i++)
            {
                var coza = (i % 3 == 0) && (i % 7 != 0) && (i % 5 != 0);
                var loza = (i % 5 == 0) && (i % 3 != 0);
                var woza = (i % 7 == 0) && (i % 3 != 0);
                var cozaloza = (i % 3 == 0) && (i % 5 == 0);
                var cozawoza = (i % 3 == 0) && (i % 7 == 0);
                var notCozaWoza = (i % 11 == 0) && false == coza && false == loza && false == woza &&
                                  false == cozaloza && false == cozawoza;

                if (coza) result += "Coza ";
                else if (cozaloza) result += "CozaLoza ";
                else if (loza) result += "Loza ";
                else if (cozawoza) result += "CozaWoza ";
                else if (woza) result += "Woza ";
                else if (notCozaWoza) result += i + " ";
                else if (coza == false && loza == false && woza == false && cozaloza == false && cozawoza == false &&
                         (i % 11 != 0)) result += i + " ";
                if (i % 11 == 0)
                {
                    result = result.Trim();
                    result += "\n";
                }
            }

            return result.TrimEnd();
        }
    }
}