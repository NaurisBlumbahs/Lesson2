using System;

namespace Lesson2Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("1.uzdevums");

            Console.WriteLine("Kā tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName + "!");

            Console.WriteLine("2.uzdevums");

            Console.WriteLine("Kāds ir tavs vecums?");

            string userAgeText = Console.ReadLine();
            int userAge = int.Parse(userAgeText);
            int ageNextYear = ++userAge;
            bool isAdult = userAge >= 18;

            if (isAdult)
            {
                Console.WriteLine($"Nākamgad tev paliks {ageNextYear}, Tu esi pilngadīgs");
            }
            if (!isAdult)
            {
                Console.WriteLine($"Nākamgad tev paliks {ageNextYear}, Tu nēesi pilngadīgs");
            }

            Console.WriteLine("3.uzdevums");

            Console.WriteLine("Ievadi divus skaitļus");

            string maxNumber1Text = Console.ReadLine();
            float maxNumber1 = float.Parse(maxNumber1Text);
            string maxNumber2Text = Console.ReadLine();
            float maxNumber2 = float.Parse(maxNumber2Text);

            float maxLargest = Math.Max(maxNumber1, maxNumber2);
            Console.WriteLine("Lielākais skaitlis ir " + maxLargest);

            Console.WriteLine("4.uzdevums");

            Console.WriteLine("Ievadi divus skaitļus");

            string minNumber1Text = Console.ReadLine();
            float minNumber1 = float.Parse(minNumber1Text);
            string minNumber2Text = Console.ReadLine();
            float minNumber2 = float.Parse(minNumber2Text);

            float minSmallest = Math.Min(minNumber1, minNumber2);
            Console.WriteLine("Mazākais skaitlis ir " + minSmallest);

            Console.WriteLine("5.uzdevums");

            Console.WriteLine("Ievadi divus skaitļus");

            string number1Text = Console.ReadLine();
            float number1 = float.Parse(number1Text);
            string number2Text = Console.ReadLine();
            float number2 = float.Parse(number2Text);

            float numDivision = number1 % number2;
            Console.WriteLine("Dalijūma atlikums ir " + numDivision);

            Console.WriteLine("6.uzdevums");

            Console.WriteLine("Ievadi vienu skaitli");

            string numberText = Console.ReadLine();
            int number = int.Parse(numberText);

            if (number % 2 == 0)
            {
                Console.WriteLine("Ievadītais skaitlis ir pāra skaitlis");
            }
            else
            {
                Console.WriteLine("Ievadītais skaitlis ir nepāra skaitlis");
            }

            Console.WriteLine("7.uzdevums");

            Console.WriteLine("Ievadi taisnstūra malu garumus");

            string side1Text = Console.ReadLine();
            double side1 = double.Parse(side1Text);
            string side2Text = Console.ReadLine();
            double side2 = double.Parse(side2Text);

            double numberToRound = side1 * side2;
            double rectAreaRounded = Math.Round(numberToRound, 2);

            Console.WriteLine("Tainstūra laukums ir " + rectAreaRounded);

            Console.WriteLine("8.uzdevums");

            Console.WriteLine("Ievadi vienādsānu trijstūra malas garumu");

            string triangleText = Console.ReadLine();
            float triangleSide = float.Parse(triangleText);

            float triArea = (MathF.Sqrt(3) / 4) * (triangleSide * triangleSide);

            Console.WriteLine("Vienādsānu trijstūra laukums ir " + triArea);

            Console.WriteLine("9.uzdevums");

            Console.WriteLine("Kāds ir tavs vārds?");
            string user1Name = Console.ReadLine();

            Console.WriteLine("Kāds ir tavs vecums?");
            string user1AgeText = Console.ReadLine();
            int user1Age = int.Parse(user1AgeText);

            string interpolatedText = $"Sveiks {user1Name}, tavs vecums ir {user1Age}";
            Console.WriteLine(interpolatedText);









        }
    }
}
