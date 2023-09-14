namespace Solutions.Three;

static class Shared
{
    public static int NToPriority(int n)
    {
        if (n >= 97)
        {
            return n - 96;
        }
        else
        {
            return n - 64 + 26;
        }
    }
}
