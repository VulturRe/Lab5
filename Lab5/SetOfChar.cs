using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    class SetOfChar
    {
        protected List<char> CharList { get; }

        public SetOfChar()
        {
           CharList = new List<char>();
        }

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
            var set1 = set;
            set1.Add(ch);
            return set1;
        }

        public static SetOfChar operator +(SetOfChar set1, SetOfChar set2)
        {
            var set = new SetOfChar();
            foreach (var c in set1.CharList)
                set.Add(c);
            for (var i = 0; i != set2.CharList.Count; i++)
                set.Add(set2.CharList[i]);
            return set;
        }

        public static bool operator ==(SetOfChar set1, SetOfChar set2)
        {
            if (set1.CharList.Count != set2.CharList.Count)
                return false;
            var trueOrFalse = false;
            for (var i = 0; i != set1.CharList.Count; i++)
            {
                if (set1.CharList[i] == set2.CharList[i])
                    trueOrFalse = true;
                else
                {
                    trueOrFalse = false;
                    break;
                }
            }
            return trueOrFalse;
        }

        public static bool operator !=(SetOfChar set1, SetOfChar set2)
        {
            if (set1.CharList.Count != set2.CharList.Count)
                return true;
            var trueOrFalse = false;
            for (var i = 0; i != set1.CharList.Count; i++)
            {
                if (set1.CharList[i] == set2.CharList[i])
                    trueOrFalse = true;
                else
                {
                    trueOrFalse = false;
                    break;
                }
            }
            return !trueOrFalse;
        }

        public override string ToString()
        {
            var str = CharList.Aggregate("", (current, s) => current + (s + " "));
            return str;
        }

        public static string DisplayMenu()
        {
            Console.WriteLine("1. Ввести первое и второе множества.");
            Console.WriteLine("2. Объединить множества.");
            Console.WriteLine("3. Сравнить множества.");
            Console.WriteLine("4. Добавить элемент в множество.");
            Console.WriteLine("5. Вывести множество.");
            Console.WriteLine("6. Выход.");

            var cki = Console.ReadKey(false);
            return cki.KeyChar.ToString();
        }
    }

    class TestSet
    {
        static void Main()
        {
            Console.Title = "Lab5";
            string userInput;
            SetOfChar set1 = null, set2 = null;

            do
            {
                userInput = SetOfChar.DisplayMenu();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Введите первое и второе множества.");
                        var chars1 = Console.ReadLine().Split(' ');
                        var chars2 = Console.ReadLine().Split(' ');
                        set1 = new SetOfChar(chars1);
                        set2 = new SetOfChar(chars2);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(set1 + set2);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(set1 == set2 ? "Множества равны." : "Множества не равны.");
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Введите номер множества.");
                        var num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите символ.");
                        var ch = Convert.ToChar(Console.ReadLine());
                        if (num == 1)
                            set1?.Add(ch);
                        else
                            set2?.Add(ch);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Введите номер множества.");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(num1 == 1 ? set1 : set2);
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный пункт меню!");
                        break;
                }
            } while (userInput != "6");
        } 
    }
}
