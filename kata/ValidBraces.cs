using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    public class ValidBraces
    {
        public bool IsValidBraces(string input)
        {
            var leftBracesStack = new Stack<char>();

            foreach (var braces in input.ToCharArray())
            {
                switch (braces)
                {
                    case ')':
                        if (leftBracesStack.Count == 0 || !leftBracesStack.Pop().Equals('('))
                            return false;
                        break;
                    case ']':
                        if (leftBracesStack.Count == 0 || !leftBracesStack.Pop().Equals('['))
                            return false;
                        break;
                    case '}':
                        if (leftBracesStack.Count == 0 || !leftBracesStack.Pop().Equals('{'))
                            return false;
                        break;
                    default:
                        leftBracesStack.Push(braces);
                        break;
                }
            }

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
