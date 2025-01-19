// 1. Convert Double to Int
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Moammmad Al-shorman ^ - ^ ");
            // Example 1
        double inputDouble = 9.8;
        int convertedInt = (int)inputDouble;
        Console.WriteLine($"Double: {inputDouble}");
        Console.WriteLine($"Converted Int: {convertedInt}");

        // Example 2
        int number = 25;
        string numberString = Convert.ToString(number);
        Console.WriteLine($"Your number is: {numberString}");

        // Example 3
        string sentence = "C# is fun!";
        Console.WriteLine($"Uppercase: {sentence.ToUpper()}");
        Console.WriteLine($"Lowercase: {sentence.ToLower()}");

        // Example 4
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();
        string[] nameParts = fullName.Split(' ');
        Console.WriteLine($"First Name: {nameParts[0]}");
        Console.WriteLine($"Last Name: {nameParts[^1]}");
        Console.WriteLine($"Total Characters: {fullName.Replace(" ", "").Length}");

        // Example 5
        Console.Write("Enter two integers separated by a space: ");
        string[] numbers = Console.ReadLine().Split(' ');
        int num1 = int.Parse(numbers[0]);
        int num2 = int.Parse(numbers[1]);
        Console.WriteLine($"Smaller Number: {Math.Min(num1, num2)}");

        // Example 6
        Console.Write("Enter speed in km/h: ");
        double kmh = double.Parse(Console.ReadLine());
        Console.WriteLine($"{kmh} km/h = {ConvertKmToMiles(kmh)} mph");

        // Example 7
        Console.Write("Enter hours and minutes (e.g., 5 37): ");
        string[] timeInput = Console.ReadLine().Split(' ');
        int hours = int.Parse(timeInput[0]);
        int minutes = int.Parse(timeInput[1]);
        Console.WriteLine($"Total: {ConvertToMinutes(hours, minutes)} minutes");

        // Example 8
        Console.Write("Enter minutes: ");
        int totalMinutes = int.Parse(Console.ReadLine());
        ConvertToHoursAndMinutes(totalMinutes);

        // Example 9
        Console.Write("Enter two numbers separated by a space: ");
        string[] compareNumbers = Console.ReadLine().Split(' ');
        int firstNumber = int.Parse(compareNumbers[0]);
        int secondNumber = int.Parse(compareNumbers[1]);
        string comparisonResult = firstNumber == secondNumber ? "Equal" : (firstNumber > secondNumber ? "Greater" : "Smaller");
        Console.WriteLine(comparisonResult);

        // Example 10
        Console.Write("Enter a number to calculate the sum of digits: ");
        int sumNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum of digits: {SumOfDigits(sumNumber)}");

        // Example 11
        Console.Write("Enter two numbers separated by a space: ");
        string[] divisibilityNumbers = Console.ReadLine().Split(' ');
        int dividend = int.Parse(divisibilityNumbers[0]);
        int divisor = int.Parse(divisibilityNumbers[1]);
        Console.WriteLine(dividend % divisor == 0 ? "Divisible" : "Not Divisible");

        // Example 12
        Console.Write("Enter three numbers separated by spaces: ");
        string[] middleNumbers = Console.ReadLine().Split(' ');
        int[] values = Array.ConvertAll(middleNumbers, int.Parse);
        Array.Sort(values);
        Console.WriteLine($"The middle value is: {values[1]}");
    }

    static double ConvertKmToMiles(double kmh)
    {
        return kmh * 0.621371;
    }

    static int ConvertToMinutes(int hours, int minutes)
    {
        return (hours * 60) + minutes;
    }

    static void ConvertToHoursAndMinutes(int totalMinutes)
    {
        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;
        Console.WriteLine($"{hours} Hours, {minutes} Minutes");
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
