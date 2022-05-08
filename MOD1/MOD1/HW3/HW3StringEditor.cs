using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MOD1.HW3
{
    public class HW3StringEditor
    {
        public HW3StringEditor()
        {
            Init();
        }

        public StringBuilder EditableString { get; private set; }

        public void NumberRemover()
        {
            Console.WriteLine("убираем числа");
            var temp = Regex.Replace(EditableString.ToString(), @"[\d-]", string.Empty);
            EditableString.Clear();
            EditableString.Append(temp.Trim());
        }

        public void ReverseOddWords()
        {
            Console.WriteLine("меняем буквы местами");
            var words = EditableString.ToString().Split(" ");
            EditableString.Clear();
            for (var i = 0; i < words.Length; i++)
            {
                var isOddWord = (i + 1) % 2 == 1;
                if (isOddWord)
                {
                    EditableString.Append($"{new string(words[i].ToCharArray().Reverse().ToArray())} ");
                }
                else if (i < words.Length - 1)
                {
                    EditableString.Append($"{words[i]} ");
                }
                else
                {
                    EditableString.Append($"{words[i]}");
                }
            }
        }

        private void Init()
        {
            Console.WriteLine();
            Console.WriteLine("Input new string");
            var temp = string.Empty;
            var flag = false;
            while (!flag)
            {
                temp = Console.ReadLine();
                flag = temp.Split(" ").Length == 5;
                if (!flag)
                {
                    Console.WriteLine("Try Again: ");
                }
            }

            EditableString = new StringBuilder();
            EditableString.Append(temp);
            Console.WriteLine("OK!");
        }
    }
}
