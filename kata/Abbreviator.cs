using System.Text.RegularExpressions;

namespace kata
{
    public class Abbreviator
    {
        public string Abbreviate(string input)
        {
            var words = Regex.Split(input, @"[^a-zA-Z]+");
            if (words.Length > 1)
            {
                return AbridgeSentence(input, words);
            }
            return AbridgeWord(input);
        }

        private string AbridgeSentence(string input, string[] words)
        {
            var sentence = input;

            for (var i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    sentence = sentence.Replace(words[i], AbridgeWord(words[i]));
                }
            }

            return sentence;
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