using System.Collections;

namespace kata
{
    public class ValidBraces
    {
        public bool IsValidBraces(string input)
        {
            char[] characterSet = input.ToCharArray();
            int index = 0;
            Stack leftBracese = new Stack();

            while (index < input.Length)
            {
                switch (characterSet[index])
                {
                    case ')':
                        if (!leftBracese.Pop().Equals('('))
                            return false;
                        break;
                    case ']':
                        if (!leftBracese.Pop().Equals('['))
                            return false;
                        break;
                    case '}':
                        if (!leftBracese.Pop().Equals('{'))
                            return false;
                        break;
                    default:
                        leftBracese.Push(characterSet[index]);
                        break;
                }
                index++;
            }

            if (leftBracese.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
