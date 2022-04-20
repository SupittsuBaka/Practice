using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD1.HW2
{
    public class HW2SelectionSort
    {
        private int[] _a;
        private int[] _b;

        public HW2SelectionSort()
        {
            _a = new int[20];
            _b = new int[20];
            FillAArr();
            FillBArr();
        }

        public void Selection()
        {
            for (var i = 0; i < _a.Length || i < _b.Length; i++)
            {
                if (_a[i] <= 888)
                {
                    _b[i] = _a[i];
                }
            }
        }

        public void BArrSort()
        {
            for (var i = 0; i < _b.Length - 1; i++)
            {
                for (var j = 0; j < _b.Length - (i + 1); j++)
                {
                    if (_b[j] < _b[j + 1])
                    {
                        _b[j] += _b[j + 1];
                        _b[j + 1] = _b[j] - _b[j + 1];
                        _b[j] -= _b[j + 1];
                    }
                }
            }
        }

        public void PrintAArr()
        {
            Console.WriteLine($"{Environment.NewLine}A:");
            foreach (var item in _a)
            {
                Console.Write($"{item} ");
            }
        }

        public void PrintBArr()
        {
            Console.WriteLine($"{Environment.NewLine}B:");
            foreach (var item in _b)
            {
                Console.Write($"{item} ");
            }
        }

        private void FillAArr()
        {
            for (var i = 0; i < _a.Length; i++)
            {
                _a[i] = new Random().Next(2000);
            }
        }

        private void FillBArr()
        {
            for (var i = 0; i < _b.Length; i++)
            {
                _b[i] = default;
            }
        }
    }
}
