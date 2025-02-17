Calculator calc = new Calculator();
Console.WriteLine(calc.Add(10, 5));       // 15
Console.WriteLine(calc.Subtract(10, 5)); // 5
Console.WriteLine(calc.Multiply(10, 5)); // 50
Console.WriteLine(calc.Divide(10, 5));   // 2
public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1+num2;
    }
    public int Subtract(int num1, int num2)
    {
        return num1-num2;
    }
    public int Multiply(int num1, int num2)
    {
        return num1*num2;
    }
    public int Divide(int num1, int num2)
    {
        return num1/num2;
    }
}
//Hej chiz ivaz nakardam
