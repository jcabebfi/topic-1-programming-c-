namespace topic_1_programming_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"
-----------------------
* Simple Calcutlator *
-----------------------");

            while (true)
            {
                Console.WriteLine("Enter the first number: ");
                int firstNumber = 0;
                int.TryParse(Console.ReadLine(), out firstNumber);

                Console.WriteLine("Enter the second number: ");
                int secondNumber = 0;
                int.TryParse(Console.ReadLine(), out secondNumber);

                Console.WriteLine($@"Choose an operation:
1. Addition
2. Subtraction
3. Multiplication
4. Division

Enter the operation Number (1-4):");

                int calcOperator = 0;
                int.TryParse(Console.ReadLine(), out calcOperator);

                int result = 0;
                string operation = "";

                if (calcOperator == 1)
                {
                    result = firstNumber + secondNumber;
                    operation = "Addition";
                }

                if (calcOperator == 2)
                {
                    result = firstNumber - secondNumber;
                    operation = "Subtraction";
                }

                if (calcOperator == 3)
                {
                    result = firstNumber * secondNumber;
                    operation = "Multiplication";
                }

                if (calcOperator == 4)
                {
                    result = firstNumber / secondNumber;
                    operation = "Division";
                }

                Console.WriteLine($"Result of {operation}: {result}\n");

            }
        }
    }
}
