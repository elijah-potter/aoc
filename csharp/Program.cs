namespace Program
{
    class Program
    {
        public static void Main()
        {
            var solver = new Solutions.Three.B();

            var reader = new StreamReader("../3.txt");
            var input = reader.ReadToEnd();

            Console.WriteLine(solver.Solve(input));
        }
    }
}
