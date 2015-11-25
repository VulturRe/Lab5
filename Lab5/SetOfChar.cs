using System;
using System.Collections.Generic;

namespace Lab5
{
    class SetOfChar
    {
        protected List<char> CharList;

        public SetOfChar(char ch)
        {
            CharList = new List<char> {ch};
        }

        public SetOfChar(string[] str)
        {
            CharList = new List<char>();
            foreach (var s in str)
                CharList.Add(Convert.ToChar(s));
        }
    }
}
