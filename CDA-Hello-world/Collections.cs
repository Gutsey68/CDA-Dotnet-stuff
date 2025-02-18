namespace CDA_Hello_world;

public class Collections
{
    public static void InverseSorter()
    {
        var numbers = new List<int>();

        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number " + (i + 1) + ":");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }
        
        numbers.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine("Sorted numbers in descending order:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public static void BubbleSorter(int[] numbers)
    {
        for (var i = 0; i < numbers.Length - 1; i++)
        {
            for (var j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // var temp = numbers[j];
                    // numbers[j] = numbers[j + 1];
                    // numbers[j + 1] = temp;
                    (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                }
            }
        }

        Console.WriteLine("The sorted numbers:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}