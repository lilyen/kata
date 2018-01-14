namespace kata
{
    public class Abbreviator
    {
        public string Abbreviate(string input)
        {
            if (input.Length >= 4)
            {
                return input[0] + (input.Length - 2).ToString() + input[input.Length - 1];
            }
            return input;
        }
    }
}