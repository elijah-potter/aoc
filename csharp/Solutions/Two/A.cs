namespace Solutions.Two;

public class TwoA : Solution
{
    public string Solve(string input)
    {
        var lines = new Queue<string>(input.Split('\n'));
        var total = 0;

        while (true)
        {
            var line = lines.Dequeue();

            if (line == "DONE")
            {
                return total.ToString();
            }

            var a = Shared.CharToMove(line[0]);
            var b = Shared.CharToMove(line[2]);

            total += Shared.CalculateScore(a, b);
        }
    }

}
