using System;

namespace Lesson2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName);

            Console.WriteLine(".....................................................................................................");

            Console.WriteLine("Kāds ir tavs vecums?");

            string userAgeText = Console.ReadLine();
            int userAge = int.Parse(userAgeText);
            int ageNextYear = ++userAge;
            bool isAdult = userAge >= 18;
      
            Console.WriteLine($"Nākamgad tev paliks {ageNextYear}, Tu esi pilngadīgs: {isAdult} ");

            Console.WriteLine(".....................................................................................................");




        }
    }
}
