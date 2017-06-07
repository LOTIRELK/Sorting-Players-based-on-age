using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a program that organises members into categories depending on their age
namespace WelcomeBack4
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter age
            Console.WriteLine("Enter the age of the competitor.");
            string input = Console.ReadLine();
            int age;
            int.TryParse(input, out age);
            if (age < 14)//if number entered less than 14
            {
                Console.WriteLine("Category A");//output Category A
            }
            else if (age >= 14 && age < 16)//if number entered is greater than or equal to 14 and  less than 16
            {
                Console.WriteLine("Category B");//output Category B
            }
            else
                Console.WriteLine("Category C");//else output Category C
        }
    }
}
