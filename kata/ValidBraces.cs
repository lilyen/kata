using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    public class ValidBraces
    {
        public bool IsValidBraces(string input)
        {
            char[] characterSet = input.ToCharArray();
            int index = 0;
            var leftBracesStack = new Stack<char>();

            foreach (var braces in input.ToCharArray())
            {
                if (IsLeftBrace(braces))
                {
                    leftBracesStack.Push(braces);
                }
                else if (!leftBracesStack.Any() || !IsPair(braces, leftBracesStack.Pop()))
                {
                    return false;
                }
            }
            //while (index < input.Length)
            //{
            //    if (IsLeftBrace(characterSet[index]))
            //    {
            //        leftBracesStack.Push(characterSet[index]);
            //    }
            //    else if (!leftBracesStack.Any() || !IsPair(characterSet[index], leftBracesStack.Pop()))
            //    {
            //        return false;
            //    }
            //    index++;
            //    //switch (characterSet[index])
            //    //{
            //    //    case ')':
            //    //        if (leftBraceses.Count == 0 || !leftBraceses.Pop().Equals('('))
            //    //            return false;
            //    //        break;
            //    //    case ']':
            //    //        if (leftBraceses.Count == 0 || !leftBraceses.Pop().Equals('['))
            //    //            return false;
            //    //        break;
            //    //    case '}':
            //    //        if (leftBraceses.Count == 0 || !leftBraceses.Pop().Equals('{'))
            //    //            return false;
            //    //        break;
            //    //    default:
            //    //        leftBraceses.Push(characterSet[index]);
            //    //        break;
            //    //}
            //    //index++;
            //}

            return (leftBracesStack.Count == 0);
        }

        public bool IsLeftBrace(char character)
        {
            switch (character)
            {
                case '(':
                case '[':
                case '{':
                    return true;
                default:
                    return false;
            }
        }

        public bool IsPair(char rightBrance, char leftBraces)
        {
            switch (rightBrance)
            {
                case ')':
                    return (leftBraces.Equals('('));
                case ']':
                    return (leftBraces.Equals('['));
                case '}':
                    return (leftBraces.Equals('{'));
                default:
                    return false;
            }
        }
    }
    
}
