using System.Linq;

namespace IsNumberHappy
{
    public class IsNumberHappy
    {
        static int Factorial(string n)
        {
            var digitsArray = n.ToCharArray();

            return digitsArray.Sum(c => int.Parse(c.ToString()) * int.Parse(c.ToString()));
        }

        public static bool IsHappy(int n)
        {
            int fast;
            var slow = fast = n;
            do
            {
                slow = Factorial(slow.ToString());
                fast = Factorial(Factorial(fast.ToString()).ToString());
            } while (slow != fast);

            return (slow == 1);
        }

       // IsHappy(inputNum)? "Happy" : "Not Happy";
        
    
}
}