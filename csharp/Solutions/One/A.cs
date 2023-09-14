namespace Solutions.One;

public class A : Solution
{
    public string Solve(string input)
    {
        var lines = new Queue<string>(input.Split('\n'));

        var maxCal = 0;

        while (true)
        {
            var inventory = Shared.ParseElfInventory(lines);
            var cal = inventory.Sum();

            if (inventory.Count == 0)
            {
                return maxCal.ToString();
            }
            else if (cal > maxCal)
            {
                maxCal = cal;
            }
        }
    }
}

