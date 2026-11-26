namespace Task2
{
    // Базовый интерфейс
    public interface ITetragon
    {
        float CountPerimeter(float a, float b);
        float CountArea(float a, float b, float angle);
    }

    // Выпуклый четырехугольник
    public interface IConvexTetragon : ITetragon
    {
    }

    // Параллелограмм
    public interface IParallelogram : IConvexTetragon
    {
    }

    // Ромб
    public interface IRhombus : IParallelogram
    {
    }

    // Прямоугольник
    public interface IRectangle : IParallelogram
    {
    }

    // Квадрат
    public interface ISquare : IRhombus
    {
    }

    // Реализация параллелограмма
    public class Parallelogram : IParallelogram
    {
        public virtual float CountPerimeter(float a, float b)
        {
            return 2 * (a + b);
        }

        public virtual float CountArea(float a, float b, float angle)
        {
            return a * b * MathF.Sin(angle * MathF.PI / 180f);
        }
    }

    // Реализация ромба
    public class Rhombus : Parallelogram, IRhombus
    {
        public override float CountPerimeter(float a, float b)
        {
            return 4 * a;
        }

        public override float CountArea(float a, float b, float angle)
        {
            return a * a * MathF.Sin(angle * MathF.PI / 180f);
        }
    }

    // Реализация прямоугольника
    public class Rectangle : Parallelogram, IRectangle
    {
        public override float CountArea(float a, float b, float angle)
        {
            return a * b;
        }
    }

    // Реализация квадрата
    public class Square : Rhombus, ISquare
    {
        public override float CountArea(float a, float b, float angle)
        {
            return a * a;
        }
    }
}
