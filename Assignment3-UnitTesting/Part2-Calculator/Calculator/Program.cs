namespace Assignment3_UnitTesting.Part2_Calculator.Calculator;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Demo ===\n");

        Calculator calc1 = new Calculator(10, 5, "+");
        Console.WriteLine(calc1.ToString());

        Calculator calc2 = new Calculator(10, 5, "-");
        Console.WriteLine(calc2.ToString());

        Calculator calc3 = new Calculator(10, 5, "*");
        Console.WriteLine(calc3.ToString());

        Calculator calc4 = new Calculator(10, 5, "/");
        Console.WriteLine(calc4.ToString());

        Console.WriteLine("\nAttempting division by zero:");
        Calculator calc5 = new Calculator(10, 0, "/");
        Console.WriteLine(calc5.ToString());

        Console.WriteLine("\nAttempting unsupported operation:");
        Calculator calc6 = new Calculator(10, 5, "%");
        Console.WriteLine(calc6.ToString());

        Console.WriteLine("\nWorking with negative numbers:");
        Calculator calc7 = new Calculator(-15, 3, "+");
        Console.WriteLine(calc7.ToString());

        Console.WriteLine("\nWorking with decimal numbers:");
        Calculator calc8 = new Calculator(7.5, 2.5, "*");
        Console.WriteLine(calc8.ToString());

        Console.WriteLine("\n=== Demo Complete ===");
    }
}