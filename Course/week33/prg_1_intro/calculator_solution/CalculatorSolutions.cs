namespace gettingstarted;

//Simply change the constructor of the testing class to
//instantiate this solution class in order to the the passed results
public class CalculatorSolutions : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Can't divide by zero");
        }
        return a / b;
    }

    public double Sqrt(int a)
    {
        if (a < 0)
        {
            throw new ArgumentOutOfRangeException("Can't square root a negative number");
        }
        return Math.Sqrt(a);
    }

    public double Power(int a, int b)
    {
        return Math.Pow(a, b);
    }

    public int Modulus(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Can't divide by zero");
        }
        return a % b;
    }

    public int Negate(int a)
    {
        return -a;
    }

    public int Abs(int a)
    {
        return Math.Abs(a);
    }
}