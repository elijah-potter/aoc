namespace Solutions.Two;

enum Move
{
    Rock = 1,
    Paper = 2,
    Scissors = 3
}

enum Outcome
{
    Lose = 0,
    Draw = 3,
    Win = 6
}

static class Shared
{

    public static int CalculateScore(Move a, Move b)
    {
        var outcome = CalculateOutcome(a, b);

        return (int)b + (int)outcome;
    }

    public static Move CharToMove(char c)
    {
        switch (c)
        {
            case 'A':
            case 'X':
                return Move.Rock;
            case 'B':
            case 'Y':
                return Move.Paper;
            case 'C':
            case 'Z':
                return Move.Scissors;
            default:
                throw new Exception("Received unexpected value.");
        }
    }

    public static Outcome CharToOutcome(char c)
    {
        switch (c)
        {
            case 'A':
            case 'X':
                return Outcome.Lose;
            case 'B':
            case 'Y':
                return Outcome.Draw;
            case 'C':
            case 'Z':
                return Outcome.Win;
            default:
                throw new Exception("Received unexpected value.");
        }
    }

    public static Outcome CalculateOutcome(Move a, Move b)
    {
        if (a == b)
        {
            return Outcome.Draw;
        }

        if (a == Move.Scissors && b == Move.Rock)
        {
            return Outcome.Win;
        }

        if (a > b || (a == Move.Rock && b == Move.Scissors))
        {
            return Outcome.Lose;
        }

        return Outcome.Win;
    }

}
