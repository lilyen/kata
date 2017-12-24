using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    //https://www.codewars.com/kata/decode-the-morse-code/train/csharp
    public class MorseCodeDecode
    {
        Dictionary<string, String> morse = new Dictionary<string, String>()
        {
            {".-", "A"},
            {"-...", "B"},
            {"-.-.", "C"},
            {"-..", "D"},
            {".", "E"},
            {"..-.", "F"},
            {"--.", "G"},
            {"....", "H"},
            {"..", "I"},
            {".---", "J"},
            {"-.-", "K"},
            {".-..", "L"},
            {"--", "M"},
            {"-.", "N"},
            {"---", "O"},
            {".--.", "P"},
            {"--.-", "Q"},
            {".-.", "R"},
            {"...", "S"},
            {"-", "T"},
            {"..-", "U"},
            {"...-", "V"},
            { ".--", "W"},
            {"-..-", "X"},
            {"-.--", "Y"},
            {"--..", "Z"},
            {"-----", "0"},
            {".----", "1"},
            {"..---", "2"},
            {"...--", "3"},
            {"....-", "4"},
            {".....", "5"},
            { "-....", "6"},
            { "--...", "7"},
            {"---..", "8"},
            {"----.", "9"},
            {"...---...", "SOS" }
        };

        public string Decode(string morseCode)
        {
            var result = "";
            var words = morseCode.Split(' ');
            var speaceNum = 0;
            foreach (var word in words)
            {
                if (word != "")
                {
                    result += morse[word];
                }
                else
                {
                    speaceNum++;
                    if (speaceNum >= 2)
                    {
                        result += " ";
                        speaceNum = 0;
                    }
                }
            }

            return result;
        }
    }
}
