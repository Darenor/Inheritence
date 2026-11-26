namespace Task1
{
    // Базовый класс
    public abstract class Tetragon
    {
        public float A { get; protected set; }
        public float B { get; protected set; }
        public float Angle { get; protected set; }

        protected Tetragon(float a, float b, float angle)
        {
            A = a;
            B = b;
            Angle = angle;
        }

        public virtual float CountPerimeter(float a, float b)
        {
            throw new NotImplementedException(
                "Для произвольного четырехугольника недостаточно данных."
            );
        }

        public virtual float CountArea(float a, float b, float angle)
        {
            throw new NotImplementedException(
                "Для произвольного четырехугольника недостаточно данных."
            );
        }
    }

    // Выпуклый четырехугольник
    public abstract class ConvexTetragon : Tetragon
    {
        protected ConvexTetragon(float a, float b, float angle)
            : base(a, b, angle)
        {
        }
    }

    // Параллелограмм
    public class Parallelogram : ConvexTetragon
    {
        public Parallelogram(float a, float b, float angle)
            : base(a, b, angle)
        {
        }

        public override float CountPerimeter(float a, float b)
        {
            return 2 * (a + b);
        }

        public override float CountArea(float a, float b, float angle)
        {
            return a * b * MathF.Sin(angle * MathF.PI / 180f);
        }
    }

    // Ромб
    public class Rhombus : Parallelogram
    {
        public Rhombus(float a, float angle)
            : base(a, a, angle)
        {
        }

        public override float CountPerimeter(float a, float b)
        {
            return 4 * a;
        }

        public override float CountArea(float a, float b, float angle)
        {
            return a * a * MathF.Sin(angle * MathF.PI / 180f);
        }
    }

    // Прямоугольник
    public class Rectangle : Parallelogram
    {
        public Rectangle(float a, float b)
            : base(a, b, 90f)
        {
        }

        public override float CountArea(float a, float b, float angle)
        {
            return a * b;
        }
    }

    // Квадрат
    public class Square : Rhombus
    {
        public Square(float a)
            : base(a, 90f)
        {
        }

        public override float CountArea(float a, float b, float angle)
        {
            return a * a;
        }
    }
}
