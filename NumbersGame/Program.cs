namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }
        static void StartSequence()
        {
            int[] numbers = new int[4]; // 
            int[] populateResult = Populate(numbers);
            int sum = GetSum(populateResult);
            Console.WriteLine(sum);
            for (int i = 0; i < populateResult.Length; i++)
            {
                Console.Write(populateResult[i] + " ");
            }

            int product = GetProduct(populateResult, sum);
            GetQuotient(product);
        }


        static int[] Populate(int[] array)
        {



            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Give me a number");
                string userInput = Console.ReadLine();
                int number = Int32.Parse(userInput);
                array[i] = number;
            }
            return array;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            if (sum < 20)
            {
                throw new Exception("You don't have the juice brother, trust me.");
            }
            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Pick a number between 1 and {0}", array.Length);
            string userInput = Console.ReadLine();
            int randomIndexInt = Int32.Parse(userInput) - 1;
            int randomNumber = array[randomIndexInt];
            Console.WriteLine("Random number is {0}", randomNumber);

            int product = randomNumber * sum;
            Console.WriteLine("This is the product: {0}", product);
            return product;
        }

        static decimal GetQuotient(int product)
        {



            Console.WriteLine("Divide something dad gummit");
            Console.ReadLine();

            string userInput = Console.ReadLine();
            int divisor = Int32.Parse(userInput);
            decimal quotient = product / divisor;
            Console.Write("This is the quotient: {0}", quotient);

            return 0;
        }


    }
}