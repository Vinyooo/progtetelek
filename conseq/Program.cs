using System;

namespace conseq
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence seq = new Sequence();
            Console.WriteLine($"Sum: {seq.Osszegkepzes()}");
            seq.Show();
        }
    }
}
