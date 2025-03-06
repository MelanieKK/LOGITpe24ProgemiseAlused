namespace random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number = new Random().Next(1, 7);

            switch ("number")

                case 1:
                Console.WriteLine("veeretasid nr " + number);
                break;

               default:
                Console.WriteLine("error");
                break;


            
        }
    }
}
