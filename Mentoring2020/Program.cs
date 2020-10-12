using System;

namespace Mentoring2020
{
    class EX1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter first number");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //string equals = "numbers are equals";

            //var rez = number1 > number2
            //    ? (number1-number2).ToString()
            //    : number1 < number2
            //        ? (number1 + number2).ToString()
            //        : equals;
            //Console.WriteLine(rez);
            //Console.ReadLine();

            //EX2.Ex2();

            EX3.Ex2();
            Console.ReadLine();
        }
    }

    class EX2
    {
        //public static void Ex2()
        //{
        //    Console.WriteLine("Enter the number from 1 to 9");
        //    int enteredValue = Convert.ToInt32(Console.ReadLine());

        //    int newValue = 0;

        //    if (enteredValue == 1 || enteredValue == 2 || enteredValue == 3)
        //    {
        //        newValue = enteredValue + 10;
        //    }
        //    else if (enteredValue == 4 || enteredValue == 5)
        //    {
        //        newValue = enteredValue * enteredValue;
        //    }
        //    else if (enteredValue == 6 || enteredValue == 7 || enteredValue == 9)
        //    {
        //        newValue = enteredValue %2;
        //    }
        //    else Console.WriteLine("Entered value is incorrect");

        //    Console.WriteLine($"New value is {newValue}");
        //}

        public static void Ex2()
        {
            Console.WriteLine("Enter the number from 1 to 9");
            int enteredValue = Convert.ToInt32(Console.ReadLine());

            switch (enteredValue)
            {
                case 1:
                case 2:
                case 3:
                    enteredValue += 10;
                    break;

                case 4:
                case 5:
                    enteredValue = (int)Math.Pow(Convert.ToDouble(enteredValue), Convert.ToDouble(enteredValue));
                    break;
                case 6:
                case 7:
                case 9:
                    enteredValue %= 2;
                    break;
                default:
                    Console.WriteLine("Entered value is incorrect");
                    break;
            }
            Console.WriteLine($"New value is {enteredValue}");
        }
    }

    class EX3
    {
        public static void Ex1V1()
        {
            Console.WriteLine("Enter Natural number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            if (enteredNumber % 2 == 1 & enteredNumber >= 3)
            {
                enteredNumber -= 1;
            }

            while (enteredNumber % 2 == 0 & enteredNumber >=2)
            {
                counter += 1;
                enteredNumber -= 2;
            }

            Console.WriteLine($"the number of even digits in the entered number is {counter}");
        }

        public static void Ex1V2()
        {
            Console.WriteLine("Enter Natural number");
            string enteredNumberAsString = Console.ReadLine();
            int enteredNumberAsInt;
            int counter = 0;
            bool success = Int32.TryParse(enteredNumberAsString, out enteredNumberAsInt);

            if (!success)
            {
                Console.WriteLine("Entered value is incorrect");
                return;
            }

            for (int i = 0; i < enteredNumberAsString.Length; i++)
            {
                if (enteredNumberAsInt % 2 == 0 & enteredNumberAsInt >= 10)
                {
                    counter += 1;
                    enteredNumberAsInt /= 10;
                }
                else if (enteredNumberAsInt % 2 == 0 & enteredNumberAsInt < 10 & enteredNumberAsInt != 0)
                {
                    counter += 1;
                }
                else enteredNumberAsInt /= 10;
            }

            Console.WriteLine($"the number of even digits in the entered number is {counter}");
        }

        public static void Ex2()
        {
            Console.WriteLine("Enter the number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int second = 1;
            int first = 0;

            if (enteredNumber == 1)
                Console.WriteLine($"Fibonacci numbers: {first}");
            else if (enteredNumber == 2)
                Console.WriteLine($"Fibonacci numbers: {first} {second}");
            else if (enteredNumber > 2)
            {
                Console.Write($"Fibonacci numbers: {first} {second}");
                int i = 3;
                while (i <= enteredNumber)
                {
                    int temp = first + second;
                    first = second;
                    second = temp;
                    Console.Write($" {temp}");
                    i += 1;
                }
                //for (int i = 3; i <= enteredNumber; i++)
                //{
                //    int temp = first + second;
                //    first = second;
                //    second = temp;
                //    Console.Write($" {temp}");
                //}
            }
            else Console.WriteLine("Entered value is incorrect");
        }

        public static void Ex3a()
        {
            Console.WriteLine("Enter the number");
            string enteredNumberAsString = Console.ReadLine();

            int counter = 0;

            char[] digits = new char[enteredNumberAsString.Length];
            for (int i=0; i < enteredNumberAsString.Length; i++)
            {
                digits[i] = enteredNumberAsString[i];
                counter +=1;
            }
            Console.WriteLine($"the number of digits in the entered number is {counter}");
        }

        public static void Ex3b()
        {
            Console.WriteLine("Enter the number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while(enteredNumber > 0)
            {
                sum += enteredNumber % 10;
                enteredNumber /= 10;
            }
            Console.WriteLine($"the sum of digits in the entered number is {sum}");
        }

        public static void Ex3c()
        {
            Console.WriteLine("Enter the number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int multiplyRez = 1;

            while (enteredNumber > 0)
            {
                multiplyRez *= enteredNumber % 10;
                enteredNumber /= 10;
            }
            Console.WriteLine($"the result of multiplying the digits in the entered number is {multiplyRez}");
        }

        public static void Ex3d()
        {
            Console.WriteLine("Enter the number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            double avg = 0;

            while (enteredNumber > 0)
            {
                sum += enteredNumber % 10;
                enteredNumber /= 10;
                counter += 1;
            }
            avg = Math.Round(Convert.ToDouble(sum) / Convert.ToDouble(counter), 2);
            Console.WriteLine($"the avg of the digits in the entered number is {avg}");
        }

        public static void Ex3e()
        {
            Console.WriteLine("Enter the number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int squareForOne = 0;
            int digit = 0;
            int sumOfSquares = 0;

            while (enteredNumber > 0)
            {
                digit = enteredNumber % 10;
                squareForOne = digit * digit;
                sumOfSquares += squareForOne;
                enteredNumber /= 10;
            }
            Console.WriteLine($"the sum of the squares of digits of the entered number is {sumOfSquares}");
        }

        public static void Ex3f()
        {
            Console.WriteLine("Enter the number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int cubeForOne = 0;
            int digit = 0;
            int sumOfCubes = 0;

            while (enteredNumber > 0)
            {
                digit = enteredNumber % 10;
                cubeForOne = digit * digit * digit;
                sumOfCubes += cubeForOne;
                enteredNumber /= 10;
            }
            Console.WriteLine($"the sum of the squares of digits of the entered number is {sumOfCubes}");
        }

        public static void Ex3g()
        {
            Console.WriteLine("Enter the number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int firstDigit = 0;

            do
            {
                firstDigit = enteredNumber % 10;
                enteredNumber /= 10;
            } while (enteredNumber > 0);

            Console.WriteLine($"the first digit of the entered number is {firstDigit}");
        }

        public static void Ex3h()
        {
            Console.WriteLine("Enter the number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            int firstDigit = 0;
            int lastDigit = 0;
            int sum = 0;

            if (enteredNumber < 10)
            {
                sum = enteredNumber % 10;
                Console.WriteLine($"the number consists of one digit {sum}");
                return;
            }

            lastDigit = enteredNumber % 10;
            while (enteredNumber >= 10)
            {
                enteredNumber /= 10;
            }
            firstDigit = enteredNumber % 10;
            sum = lastDigit + firstDigit;
            
            Console.WriteLine($"the sum of the first and last digits of the entered number is {sum}");
        }
    }
}
