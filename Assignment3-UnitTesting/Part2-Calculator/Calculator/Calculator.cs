namespace Assignment3_UnitTesting.Part2_Calculator.Calculator;

public class Calculator
{
    private readonly double a;
    private readonly double b;
    private readonly string operation;

    public Calculator(double a, double b, string operation)
    {
        this.a = a;
        this.b = b;
        this.operation = operation;
    }

    public double Calculate()
    {
        return operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b == 0 
                ? throw new DivideByZeroException("Cannot divide by zero") 
                : a / b,
            _ => throw new InvalidOperationException($"Unsupported operation: {operation}")
        };
    }

    public override string ToString()
    {
        try
        {
            double result = Calculate();
            return $"{a} {operation} {b} = {result}";
        }
        catch (Exception ex)
        {
            return $"{a} {operation} {b} = Error: {ex.Message}";
        }
    }
}