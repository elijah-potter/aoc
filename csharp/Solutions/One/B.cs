namespace Solutions.One;

public class B : Solution
{
    public string Solve(string input)
    {
        var lines = new Queue<string>(input.Split('\n'));
        var cals = new List<int>();

        while (true)
        {
            var inventory = Shared.ParseElfInventory(lines);
            var cal = inventory.Sum();

            if (cal > 0)
            {
                cals.Add(cal);
            }
            else
            {
                cals.Sort();
                return cals.TakeLast(3).Sum().ToString();
            }
        }
    }

}

