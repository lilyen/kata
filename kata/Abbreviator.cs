namespace kata
{
    public class Abbreviator
    {
        public string Abbreviate(string input)
        {
            var words = input.Split(' ');
            if (words.Length > 1)
            {
                for (var i = 0; i < words.Length; i++)
                {
                    if (words[i].Length >= 4)
                    {
                        words[i] = words[i][0] + (words[i].Length - 2).ToString() + words[i][words[i].Length - 1];
                    }
                    words[i] = words[i];
                }

                var temp = words[0];
                for (var i = 1; i < words.Length; i++)
                {
                    temp += " " + words[i];
                }
                return temp;
            }
            if (input.Length >= 4)
            {
                return input[0] + (input.Length - 2).ToString() + input[input.Length - 1];
            }
            return input;
        }
    }
}