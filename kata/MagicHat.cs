namespace kata
{
    //https://www.codewars.com/kata/simple-fun-number-158-not-so-randoms
    public class MagicHat
    {
        public string NotSoRandom(double black, double white)
        {
            if (black == 1)
            {
                return "Black";
            }
            else if (white == 1)
            {
                return "White";
            }

            return "Unsure";
        }
    }
}