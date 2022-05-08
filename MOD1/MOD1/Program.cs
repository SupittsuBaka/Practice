using System;
using MOD1.HW1;
using MOD1.HW2;
using MOD1.HW3;

namespace MOD1
{
    public class Program
    {
        public static void Main()
        {
            /*HW1*/
            var person = new HW1person("Евгений", "Ендальцев", 20);
            person.Print();

            /*HW2*/
            var inRange = new HW2InRange(100);
            inRange.PrintArray();
            inRange.CheckInRange();
            Console.WriteLine();

            var selectSort = new HW2SelectionSort();
            Console.Write($"{Environment.NewLine}Before selecting:");
            selectSort.PrintAArr();
            selectSort.PrintBArr();
            selectSort.Selection();
            Console.Write($"{Environment.NewLine}After selecting/Before sorting:");
            selectSort.PrintAArr();
            selectSort.PrintBArr();
            selectSort.BArrSort();
            Console.Write($"{Environment.NewLine}After sorting:");
            selectSort.PrintBArr();
            Console.WriteLine();

            /*HW3*/
            var stringEditor = new HW3StringEditor();
            stringEditor.NumberRemover();
            Console.WriteLine(stringEditor.EditableString);
            stringEditor.ReverseOddWords();
            Console.WriteLine(stringEditor.EditableString);
        }
    }
}
