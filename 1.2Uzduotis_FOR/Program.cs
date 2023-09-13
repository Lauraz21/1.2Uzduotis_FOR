namespace _1._2Uzduotis_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double mult = 0;

            Console.WriteLine($"Atsakymas: ");

            for (int i = 1; i <= n; i++)
            {
                mult = Math.Pow(i,2);
               
                Console.WriteLine(mult);
            }
        }
    }
}