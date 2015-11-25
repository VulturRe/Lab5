using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    class SetOfChar
    {
        protected List<char> CharList { get; }

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

        public void Add(char ch)
        {
            CharList.Add(ch);
        }

        public static SetOfChar operator +(SetOfChar set, char ch)
        {
            set.Add(ch);
            return set;
        }

        public static SetOfChar operator +(SetOfChar set1, SetOfChar set2)
        {
            foreach (var c in set2.CharList)
                set1.Add(c);
            return set1;
        }

        public override string ToString()
        {
            var str = CharList.Aggregate("", (current, s) => current + (s + " "));
            return str;
        }
    }
}
