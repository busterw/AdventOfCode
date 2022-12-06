using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Part1();
        Part2();
    }

    private static void Part1()
    {
        int highestTotal = 0;

        var input = File.ReadAllText("input.txt");

        var splitString = input.Split("\n\n");

        var numberList = splitString.Select(x => x.Split("\n"));

        foreach (var numbers in numberList)
        {
            int currentTotal = 0;

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int parsedNumber))
                    currentTotal += parsedNumber;
            }

            if (currentTotal > highestTotal)
                highestTotal = currentTotal;
        }

        Console.WriteLine(highestTotal);
    }

    private static void Part2()
    {
        var input = File.ReadAllText("input.txt");

        var splitString = input.Split("\n\n");

        var numberList = splitString.Select(x => x.Split("\n"));

        var totals = new List<int>();

        foreach (var numbers in numberList)
        {
            int currentTotal = 0;

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int parsedNumber))
                    currentTotal += parsedNumber;
            }

            totals.Add(currentTotal);
        }

        totals.Sort();
        totals.Reverse();

        var top3total = totals[0] + totals[1] + totals[2];

        Console.WriteLine(top3total);
    }
}
