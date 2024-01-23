using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);

        Console.WriteLine(f3.GetTop());
        f3.SetTop(10);
        Console.WriteLine(f3.GetTop());

        Console.WriteLine(f3.GetBottom());
        f3.SetBottom(5);
        Console.WriteLine(f3.GetBottom());

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f4 = new Fraction(5);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Fraction f5 = new Fraction(3,4);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        Fraction f6 = new Fraction(1,3);
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());
        

    }
}