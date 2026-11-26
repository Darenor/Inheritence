
using System;

class Program
{
    static void Main()
    {
        // ==========================
        // ЗАДАНИЕ 1 — НАСЛЕДОВАНИЕ
        // ==========================

        Console.WriteLine("========== ЗАДАНИЕ 1 ==========");

        Task1.Parallelogram parallelogram =
            new Task1.Parallelogram(5, 3, 60);

        Task1.Rhombus rhombus =
            new Task1.Rhombus(5, 60);

        Task1.Rectangle rectangle =
            new Task1.Rectangle(5, 3);

        Task1.Square square =
            new Task1.Square(4);

        Console.WriteLine("\nПараллелограмм:");
        Console.WriteLine($"Периметр: {parallelogram.CountPerimeter(5, 3)}");
        Console.WriteLine($"Площадь: {parallelogram.CountArea(5, 3, 60)}");

        Console.WriteLine("\nРомб:");
        Console.WriteLine($"Периметр: {rhombus.CountPerimeter(5, 5)}");
        Console.WriteLine($"Площадь: {rhombus.CountArea(5, 5, 60)}");

        Console.WriteLine("\nПрямоугольник:");
        Console.WriteLine($"Периметр: {rectangle.CountPerimeter(5, 3)}");
        Console.WriteLine($"Площадь: {rectangle.CountArea(5, 3, 90)}");

        Console.WriteLine("\nКвадрат:");
        Console.WriteLine($"Периметр: {square.CountPerimeter(4, 4)}");
        Console.WriteLine($"Площадь: {square.CountArea(4, 4, 90)}");


        // ==========================
        // ЗАДАНИЕ 2 — ИНТЕРФЕЙСЫ
        // ==========================

        Console.WriteLine("\n========== ЗАДАНИЕ 2 ==========");

        Task2.IParallelogram parallelogram2 =
            new Task2.Parallelogram();

        Task2.IRhombus rhombus2 =
            new Task2.Rhombus();

        Task2.IRectangle rectangle2 =
            new Task2.Rectangle();

        Task2.ISquare square2 =
            new Task2.Square();

        Console.WriteLine("\nПараллелограмм:");
        Console.WriteLine($"Периметр: {parallelogram2.CountPerimeter(5, 3)}");
        Console.WriteLine($"Площадь: {parallelogram2.CountArea(5, 3, 60)}");

        Console.WriteLine("\nРомб:");
        Console.WriteLine($"Периметр: {rhombus2.CountPerimeter(5, 5)}");
        Console.WriteLine($"Площадь: {rhombus2.CountArea(5, 5, 60)}");

        Console.WriteLine("\nПрямоугольник:");
        Console.WriteLine($"Периметр: {rectangle2.CountPerimeter(5, 3)}");
        Console.WriteLine($"Площадь: {rectangle2.CountArea(5, 3, 90)}");

        Console.WriteLine("\nКвадрат:");
        Console.WriteLine($"Периметр: {square2.CountPerimeter(4, 4)}");
        Console.WriteLine($"Площадь: {square2.CountArea(4, 4, 90)}");
    }
}
