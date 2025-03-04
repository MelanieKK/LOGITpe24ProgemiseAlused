namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)


        {
            //küsi kasutajalt numbrit
            Console.WriteLine("sisesta number");
            string kasutajaSisend = Console.ReadLine();

            if (int.TryParse(kasutajaSisend, out int number))

                if (number % 2 = 0)

                    Console.WriteLine($"number {number} on paari.");
                else

                    Console.WriteLine($"numbr {number} on paaritu.");

            else

                Console.WriteLine("sisestaśite vale numbri!");
        }
    }
}
