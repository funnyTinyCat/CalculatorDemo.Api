namespace CalculatorDemo.Api.Models;

public class Calculator
{
    public int Add(int value1, int value2)
    {
        return value1 + value2;
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