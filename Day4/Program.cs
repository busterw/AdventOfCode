internal class Program
{
    private static void Main(string[] args)
    {
        Part1();
        Part2();
    }

    private static void Part1()
    {
        int count = 0;
        var input = File.ReadAllText("input.txt");

        var pairs = input.Split('\n');
        pairs = pairs.Take(1000).ToArray();

        foreach (var pair in pairs)
        {
            var firstNumbers = pair.Split(',')[0].Split('-');
            var secondNumbers = pair.Split(",")[1].Split('-');

            if (int.Parse(firstNumbers[0]) <= int.Parse(secondNumbers[0]) && int.Parse(firstNumbers[1]) >= int.Parse(secondNumbers[0]))
                count++;
            else if (int.Parse(firstNumbers[0]) <= int.Parse(secondNumbers[1]) && int.Parse(firstNumbers[1]) <= int.Parse(secondNumbers[1]))
                count++;
        }

        Console.WriteLine(count);
    }

    private static void Part2()
    {
        int count = 0;
        var input = File.ReadAllText("input.txt");

        var pairs = input.Split('\n');
        pairs = pairs.Take(1000).ToArray();

        foreach (var pair in pairs)
        {
            var firstNumbers = pair.Split(',')[0].Split('-');

            List<int> firstNumberList = new List<int>();

            for (int i = int.Parse(firstNumbers[0]); i <= int.Parse(firstNumbers[1]); i++)
            {
                firstNumberList.Add(i);
            }

            var secondNumbers = pair.Split(",")[1].Split('-');

            List<int> secondNumberList = new List<int>();

            for (int i = int.Parse(secondNumbers[0]); i <= int.Parse(secondNumbers[1]); i++)
            {
                secondNumberList.Add(i);
            }

            if(firstNumberList.Intersect(secondNumberList).Count() > 0) 
            {
                count++;
            }

        }

        Console.WriteLine(count);
    }
}