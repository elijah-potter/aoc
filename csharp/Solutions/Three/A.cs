using System.Text;
namespace Solutions.Three;

class A : Solution
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

            total += CalculateTotalPriority(line);
        }
    }

    private static int CalculateTotalPriority(string sack)
    {
        var bytesack = Encoding.UTF8.GetBytes(sack);

        var cmp1 = new HashSet<int>(bytesack[0..(bytesack.Length / 2)].Select(v => Shared.NToPriority(v)));
        var cmp2 = new HashSet<int>(bytesack[(bytesack.Length / 2)..bytesack.Length].Select(v => Shared.NToPriority(v)));

        var res = cmp1.Intersect(cmp2);
        return res.Sum();
    }
}
