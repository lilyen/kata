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
                RemoveMarbles();
            }
            
            return ReturnResultMsg();
        }

        private void RemoveMarbles()
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

        private string ReturnResultMsg()
        {
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
            var tmpTime = (int)(_blackMarbles / 2);
            _blackMarbles -= (2 * tmpTime);
            _whiteMarbles += (1 * tmpTime);
        }

        private void RemoveTwoWhiteMarbles()
        {
            var tmpTime = (int)(_whiteMarbles / 2);
            _whiteMarbles -= 1 * tmpTime;
        }

        private void RemoveTwoDifMarbles()
        {
            _whiteMarbles -= 1;
        }
    }
}