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

        var backpacks = input.Split('\n');

        int score = 0;

        foreach (var backpack in backpacks)
        {
            var firstHalf = backpack[..(backpack.Length / 2)];
            var secondHalf = backpack.Substring(backpack.Length / 2, backpack.Length / 2);

            var commonChars = firstHalf.Intersect(secondHalf);

            foreach (var character in commonChars)
            {
                score += (int)Enum.Parse<CharacterValues>(character.ToString());
            }
        }

        Console.WriteLine(score);
    }

    private static void Part2()
    {
        var input = File.ReadAllText("input.txt");

        var backpacks = input.Split('\n');

        int score = 0;

        for (int i = 0; i <= backpacks.Length - 3; i += 3)
        {
            int maxSelect = i + 3;
            var itemstoCompare = backpacks[i..maxSelect];

            var firstTwoCommonChars = itemstoCompare[0].Intersect(itemstoCompare[1]);
            var secondTwoCommonChars = itemstoCompare[1].Intersect(itemstoCompare[2]);

            var allThreeCommonChars = firstTwoCommonChars.Intersect(secondTwoCommonChars);

            foreach (var character in allThreeCommonChars)
            {
                score += (int)Enum.Parse<CharacterValues>(character.ToString());
            }
        }

        Console.WriteLine(score);
    }

    private enum CharacterValues
    {
        a = 1,
        b = 2,
        c = 3,
        d = 4,
        e = 5,
        f = 6,
        g = 7,
        h = 8,
        i = 9,
        j = 10,
        k = 11,
        l = 12,
        m = 13,
        n = 14,
        o = 15,
        p = 16,
        q = 17,
        r = 18,
        s = 19,
        t = 20,
        u = 21,
        v = 22,
        w = 23,
        x = 24,
        y = 25,
        z = 26,
        A = 27,
        B = 28,
        C = 29,
        D = 30,
        E = 31,
        F = 32,
        G = 33,
        H = 34,
        I = 35,
        J = 36,
        K = 37,
        L = 38,
        M = 39,
        N = 40,
        O = 41,
        P = 42,
        Q = 43,
        R = 44,
        S = 45,
        T = 46,
        U = 47,
        V = 48,
        W = 49,
        X = 50,
        Y = 51,
        Z = 52
    }

}