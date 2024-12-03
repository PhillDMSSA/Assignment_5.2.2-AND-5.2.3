namespace Assignment_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers to print: ");
            int input = Convert.ToInt32(Console.ReadLine());

            PrintNumber(input);
            Console.WriteLine();


           // Assignment_5._2._2
            PrintNumberBackwards(input);

          

        }
        static void PrintNumber (int number)
        {

            if (number > 0)
            {
                PrintNumber(number - 1);
                Console.Write(number + " ");
            }
        }
        //Assignment_5._2._3
        static void PrintNumberBackwards(int number)
        {
            if (number > 0)
            {
                Console.Write(number + " ");
                PrintNumberBackwards(number - 1);
            }
        }

        
    }
}
