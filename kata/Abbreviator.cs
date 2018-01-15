using System.Text.RegularExpressions;

namespace kata
{
    public class Abbreviator
    {
        public string Abbreviate(string input)
        {
            var words = Regex.Split(input, @"[^a-zA-Z]+");
            var sentence = input;
            if (words.Length > 1)
            {
                for (var i = 0; i < words.Length; i++)
                {
                    if (words[i] != "")
                    {
                        sentence = sentence.Replace(words[i], AbridgeWord(words[i]));
                    }
                }
                return sentence;
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