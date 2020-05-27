using System;

namespace LegalDrivingAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Legal Driving Age");
            Console.WriteLine("We are going to tell you if it is legal for you to drive!");
            Console.WriteLine("What is your age?");
            int age = Int32.Parse(Console.ReadLine());

            if (age < 0) {
                Console.WriteLine("You have entered an invalid age, please enter a valid age.");
                age = Int32.Parse(Console.ReadLine());
            }

            var result = age >= 16 ? "You are old enough to legally drive!" : "You are not old enough to legally drive!";
            Console.WriteLine(result);
        }
    }
}
