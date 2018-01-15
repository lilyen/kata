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
                    words[i] = AbridgeWord(words[i]);
                }

                var temp = words[0];
                for (var i = 1; i < words.Length; i++)
                {
                    temp += " " + words[i];
                }
                return temp;
            }
            return AbridgeWord(input);
        }

        private string AbridgeWord(string word)
        {
            if (word.Length >= 4)
            {
                return word[0] + (word.Length - 2).ToString() + word[word.Length - 1];
            }
            return word;
        }
    }
}