namespace CalculatorDemo.Api.Models;

public class Calculator
{
    public int Add(int value1, int value2)
    {
        return value1 + value2;
    }

    public int Calculate(string operation, int value1, int value2)
    {
        if (operation == "Add")
        {
            return Add(value1, value2);
        }
        else if (operation == "Subtract")
        {
            return Subtract(value1, value2);
        }
        else if (operation == "Multiply")
        {
            return Multiply(value1, value2);
        }
        else if (operation == "Divide")
        {
            return Divide(value1, value2);
        } else
        {
            throw new InvalidOperationException($"Unsupported operation: {operation}");
        } 
    }

    public int Divide(int value1, int value2)
    {
        if (value2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return value1 / value2;
    }

    public int Multiply(int value1, int value2)
    {
        return value1 * value2;
    }

    public int Subtract(int value1, int value2)
    {
        return value1 - value2;
    }
}