namespace Solutions.One;

static class Shared
{

    /// <summary>
    /// Reads from the file line-by line, parsing numbers to evaluate elf inventories 
    /// Returns an empty list when "DONE" is encountered.
    /// </summary>
    public static List<int> ParseElfInventory(Queue<string> lines)
    {
        var output = new List<int>();

        while (true)
        {
            var line = lines.Dequeue();

            if (line == "")
            {
                return output;
            }
            else if (line == "DONE")
            {
                return new List<int>();
            }
            else
            {
                output.Add(int.Parse(line));
            }
        }
    }
}
