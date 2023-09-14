using System.Text;
namespace Solutions.Three;

class B : Solution
{
    public string Solve(string input)
    {
        var lines = new Queue<string>(input.Split('\n'));
        var total = 0;

        while (true)
        {
            var line1 = lines.Dequeue();

            if (line1 == "DONE")
            {
                return total.ToString();
            }

            string[] g = { line1, lines.Dequeue(), lines.Dequeue() };
            total += CalculateTotalPriority(g);
        }
    }

    private static int CalculateTotalPriority(string[] group)
    {
        if (group.Length < 1)
        {
            return 0;
        }

        var bytesacks = group.Select(sack => Encoding.UTF8.GetBytes(sack));
        var priorities = bytesacks.Select(sack => new HashSet<int>(sack.Select(x => Shared.NToPriority(x))));

        var current = priorities.First();

        foreach (var x in priorities)
        {
          current = new HashSet<int>(current.Intersect(x));
        }

        return current.Sum();
    }
}
