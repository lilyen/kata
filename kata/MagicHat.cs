namespace kata
{
    //https://www.codewars.com/kata/simple-fun-number-158-not-so-randoms
    public class MagicHat
    {
        public string NotSoRandom(double black, double white)
        {
            var blackMarbles = black;
            var whiteMarbles = white;
            if (blackMarbles == 2)
            {
                blackMarbles -= 2;
                whiteMarbles += 1;
            }
            else if(whiteMarbles == 2)
            {
                whiteMarbles -= 1;
            } else if (blackMarbles == 1 && whiteMarbles == 1)
            {
                whiteMarbles -= 1;
            }
            
            if (blackMarbles == 1 && blackMarbles+ whiteMarbles == 1)
            {
                return "Black";
            }
            else if (whiteMarbles == 1 && blackMarbles + whiteMarbles == 1)
            {
                return "White";
            }

            return "Unsure";
        }
    }
}