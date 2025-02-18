using System.Text;

namespace CDA_Hello_world;

public abstract class Exercices
{
    public static void AskNumberAndTransform()
    {
        Console.WriteLine("Enter a number:");

        while (true)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    number = number * -1;
                }

                Console.WriteLine("Transformed number: " + number);
                break;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    public static void IsLeapYear()
    {
        Console.WriteLine("Enter a year:");

        while (true)
        {
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());

                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine("The year " + year + " is a leap year.");
                }
                else
                {
                    Console.WriteLine("The year " + year + " is not a leap year.");
                }

                break;
            }
            catch
            {
                Console.WriteLine("Please enter a valid year.");
            }
        }
    }

    public static void WitchIsTheNearest()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter number 1:");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2:");
                int number2 = Convert.ToInt32(Console.ReadLine());

                if (50 - number1 < 50 - number2)
                {
                    Console.WriteLine("The nearest number to 50 is: " + number1);
                }
                else
                {
                    Console.WriteLine("The nearest number to 50 is: " + number2);
                }

                break;
            }
            catch
            {
                Console.WriteLine("You must enter valid numbers, try again !");
            }
        }
    }

    public static bool IsArmstrongNumber(int number)
    {
        int temp = number;
        int sum = 0;

        while (temp != 0)
        {
            int remainder = temp % 10;
            sum += (int)Math.Pow(remainder, 3);
            temp /= 10;
        }

        return sum == number;
    }

    public static void VowelCounter(string str)
    {
        int numberOfMin = 0;
        int numberOfMaj = 0;
        
        foreach (char c in str)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
            {
                numberOfMin++;
            }
            else if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y')
            {
                numberOfMaj++;
            }
        }
        
        Console.WriteLine("Number of vowels in lowercase: " + numberOfMin);
        Console.WriteLine("Number of vowels in uppercase: " + numberOfMaj);
    }

    public static string LongestWord(string str)
    {
        string[] splittedString = str.Split(' ');
        int biggestLength = 0;
        string biggestWord = string.Empty;

        foreach (var word in splittedString)
        {
            if (word.Length > biggestLength)
            {
                biggestLength = word.Length;
                biggestWord = word;
            }
        }
        Console.WriteLine($@"The biggest word is {biggestWord}");
        return biggestWord;
    }

    public static string StringCompressor(string str)
    {
        var result = new StringBuilder();
        var currentChar = str[0];
        var count = 1;

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == currentChar)
            {
                count++;
            }
            else
            {
                result.Append(currentChar);
                result.Append(count);
                currentChar = str[i];
                count = 1;
            }
        }
    
        result.Append(currentChar);
        result.Append(count);
        
        Console.WriteLine(result);

        return result.ToString();
    }
}
