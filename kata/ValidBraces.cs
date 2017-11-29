using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    public class ValidBraces
    {
        public bool IsValidBraces(string input)
        {
            var openBraceStack = new Stack<char>();

            foreach (var brace in input)
            {
                if (IsAnOpen(brace))
                {
                    openBraceStack.Push(brace);
                }
                else if (openBraceStack.Count == 0 || !IsPair(brace, openBraceStack.Pop()))
                {
                    return false;
                }
            }

            return (openBraceStack.Count == 0);
        }

        public bool IsAnOpen(char character)
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
