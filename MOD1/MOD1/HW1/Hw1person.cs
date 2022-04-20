using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD1.HW1
{
    public class HW1person
    {
        public HW1person()
        {
        }

        public HW1person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            NumberOfYearsUpToForty = 40 - Age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int NumberOfYearsUpToForty { get; private set; }

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}.{Environment.NewLine}До начала новой жизни мне осталось {NumberOfYearsUpToForty} лет.");
        }
    }
}
