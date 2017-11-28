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
