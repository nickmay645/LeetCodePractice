using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var k = new Stack<char>();
            var d = new Dictionary<char, char> { { '}', '{' }, { ']', '[' }, { ')', '(' } };

            foreach (var c in s)
            {
                if ("{[(".Contains(c))
                {
                    k.Push(c);
                }
                else 
                {
                    if (k.Count < 1 || k.Peek() != d[c])
                        return false;
                    k.Pop();
                }
            }
            return !k.Any();
        }
    }
}
