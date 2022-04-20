using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD1.HW2
{
    public class HW2InRange
    {
        private int _n;
        private int[] _arr;

        public HW2InRange(int n)
        {
            _n = n;
            _arr = new int[_n];
            FillArray(_arr);
        }

        public void PrintArray()
        {
            Console.WriteLine($"{Environment.NewLine}Array: ");
            foreach (var item in _arr)
            {
                Console.Write($"{item} ");
            }
        }

        public void CheckInRange()
        {
            var counter = 0;
            for (var i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] >= -100 && _arr[i] <= 100)
                {
                    counter++;
                }
            }

            Console.WriteLine($"{Environment.NewLine}Things in range: {counter}");
        }

        private void FillArray(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(-1000, 1001);
            }
        }
    }
}
