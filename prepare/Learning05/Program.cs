using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("Green", 5);
        Console.WriteLine(sq.GetColor());
        Console.WriteLine(sq.GetArea());

        Console.WriteLine();

        Rectangle rec = new Rectangle("Purple", 5, 7);
        Console.WriteLine(rec.GetColor());
        Console.WriteLine(rec.GetArea());

        Console.WriteLine();

        Circle cir = new Circle("Pink", 5);
        Console.WriteLine(cir.GetColor());
        Console.WriteLine(cir.GetArea());

        Console.WriteLine("\nList:");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(sq);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine();
        }


    }
}