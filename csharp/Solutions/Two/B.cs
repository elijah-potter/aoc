namespace Solutions.Two;

public class B : Solution
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
            var outcome = Shared.CharToOutcome(line[2]);
            var b = MatchMoveWithOutcome(a, outcome);

            total += Shared.CalculateScore(a, b);
        }
    }

    /// <summary>
    /// Given a known <paramref name="move"/>, and the outcome of a play, calculate the opponent's move.
    //// </summary>
    private Move MatchMoveWithOutcome(Move move, Outcome outcome)
    {
        if (outcome == Outcome.Draw)
        {
            return move;
        }

        if (outcome == Outcome.Win)
        {
            return (Move)((int)move % 3 + 1);
        }

        return (Move)(((int)move + 1) % 3 + 1);
    }
}
