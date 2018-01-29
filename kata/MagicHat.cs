namespace kata
{
    //https://www.codewars.com/kata/simple-fun-number-158-not-so-randoms
    public class MagicHat
    {
        private double _whiteMarbles;
        private double _blackMarbles;

        public string NotSoRandom(double black, double white)
        {
            _blackMarbles = black;
            _whiteMarbles = white;
            while (_blackMarbles + _whiteMarbles > 1)
            {
                if (_blackMarbles >= 2)
                {
                    RemoveTwoBlackMarbles();
                }
                else if (_whiteMarbles >= 2)
                {
                    RemoveTwoWhiteMarbles();
                }
                else if (_blackMarbles >= 1 && _whiteMarbles >= 1)
                {
                    RemoveTwoDifMarbles();
                }
            }
            
            if (_blackMarbles == 1)
            {
                return "Black";
            }
            else if (_whiteMarbles == 1)
            {
                return "White";
            }

            return "Unsure";
        }

        private void RemoveTwoBlackMarbles()
        {
            _blackMarbles -= 2;
            _whiteMarbles += 1;
        }

        private void RemoveTwoWhiteMarbles()
        {
            _whiteMarbles -= 1;
        }

        private void RemoveTwoDifMarbles()
        {
            _whiteMarbles -= 1;
        }
    }
}