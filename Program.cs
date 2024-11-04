namespace Assignment1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a simple console application and store your name, age (should take decimal),
            // address in a string variable and print them back on console. Prompt the user to each time enter name, age and address.

            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            double myAge = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your address");
            string myAddress = Console.ReadLine();

            Console.WriteLine("\nMy name is " + myName + ", my age is " + myAge + ", and my height is " + myAddress + ".");


            // 2. Create a simple console application and declare basic datatypes like int, float, decimal, double and print their min and max values.
            int numMin = int.MinValue;
            int numMax = int.MaxValue;
            float pointMin = float.MinValue;
            float pointMax = float.MaxValue;
            decimal decMin = decimal.MinValue;
            decimal decMax = decimal.MaxValue;
            double dubMin =double.MinValue;
            double dubMax = double.MaxValue;

            Console.WriteLine("\n| Int min: " + numMin + " Int Max: " + numMax);
            Console.WriteLine("| Float min: " + pointMin + " Float Max: " + pointMax);
            Console.WriteLine("| Decimal min: " + decMin + " Decimal Max: " + decMax);
            Console.WriteLine("| Double min: " + dubMin + " Double Max: " + dubMax);

            // 3. Write a C# Sharp program to print the sum of two numbers.

            int x = 5;
            int y = 5;
            int sum = x + y;
            Console.WriteLine("\nThe sum of x and y is " + sum);

            // 4. Write a C# Sharp program to print the result of dividing two numbers.

            int div = sum / y;
            Console.WriteLine("\nSum divided by y is " + div);
        }
    }
}
