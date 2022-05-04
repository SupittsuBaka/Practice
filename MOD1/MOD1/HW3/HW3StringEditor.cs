using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD1.HW3
{
    public class HW3StringEditor
    {
        private string _editableString;
        public HW3StringEditor()
        {
            Init();
        }

        public void NumberRemover()
        {
            /*
            Console.WriteLine("убираем числа");
            for (var i = 0; i < _editableString.Length; i++)
            {
                var number = 0;
                if (int.TryParse(_editableString[i], out number))
                {
                    _editableString = _editableString.Replace(_editableString[i].ToString(), string.Empty);
                }
            }
            */
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

            _editableString = temp;
            Console.WriteLine("OK!");
        }
    }
}
