internal class Program
{
    private static void Main(string[] args)
    {
        Part1();
        Part2();
    }

    private static void Part1()
    {
        var input = File.ReadAllText("input.txt");

        var rounds = input.Split('\n');

        int score = 0;

        foreach(var round in rounds) 
        {
            switch (round)
            {
                case "A X":
                    score += 1; //rock
                    score += 3; //draw
                    break;
                case "A Y":
                    score += 2; //rock
                    score += 6; //win
                    break;
                case "A Z":
                    score += 3; //rock
                    score += 0; //lose
                    break;
                case "B X":
                    score += 1; //paper
                    score += 0; //lose
                    break;
                case "B Y":
                    score += 2; //paper
                    score += 3; //draw
                    break;
                case "B Z":
                    score += 3; //paper
                    score += 6; //win
                    break;
                case "C X":
                    score += 1; //scissors
                    score += 6; //win
                    break;
                case "C Y":
                    score += 2; //scissors
                    score += 0; //lose
                    break;
                case "C Z":
                    score += 3; //scissors
                    score += 3; //draw
                    break;
            }
        }

        
        Console.WriteLine(score);

    }

    private static void Part2()
    {
        var input = File.ReadAllText("input.txt");

        var rounds = input.Split('\n');

        int score = 0;

        foreach (var round in rounds)
        {
            switch (round)
            {
                case "A X":
                    score += 3;
                    break;
                case "A Y":
                    score += 4;
                    break;
                case "A Z":
                    score += 8;
                    break;
                case "B X":
                    score += 1;
                    break;
                case "B Y":
                    score += 5;
                    break;
                case "B Z":
                    score += 9;
                    break;
                case "C X":
                    score += 2;
                    break;
                case "C Y":
                    score += 6;
                    break;
                case "C Z":
                    score += 7;
                    break;
            }

        }


        Console.WriteLine(score);

    }
}