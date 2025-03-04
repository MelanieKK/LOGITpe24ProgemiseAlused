namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta vanus");

            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)

                Console.WriteLine("oled alaealine.");

            else if (age >= 18 && age <= 64)

                Console.WriteLine("oled täisealine");

            else if (age >= 64 && age <= 98)

                Console.WriteLine("oled pensionäär");

            else

                Console.WriteLine("Vanus on liiga kõrge, et määretleda");
        }
    }
}
