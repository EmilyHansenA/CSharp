using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;

        public double GetLength() => Geometry.GetLength(this);

        public Vector Add(Vector vector) => Geometry.Add(this, vector);

        public bool Belongs(Segment segment) => Geometry.IsVectorInSegment(this, segment);
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;

        public double GetLength() => Geometry.GetLength(this);

        public bool Contains(Vector vector) => Geometry.IsVectorInSegment(vector, this);
    }

    public static class Geometry
    {
        public static double GetLength(Vector vector) =>
            Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);

        public static double GetLength(Segment segment) =>
            Math.Sqrt(Math.Pow(segment.End.X - segment.Begin.X, 2) + Math.Pow(segment.End.Y - segment.Begin.Y, 2));

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            return ((vector.X - segment.Begin.X) * (segment.End.Y - segment.Begin.Y) ==
                    (segment.End.X - segment.Begin.X) * (vector.Y - segment.Begin.Y))
                   && (vector.X >= segment.Begin.X && vector.X <= segment.End.X
                   && vector.Y >= segment.Begin.Y && vector.Y <= segment.End.Y);
        }

        public static Vector Add(Vector vector1, Vector vector2) =>
            new Vector { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y };
    }

    class Program
    {
        static void Main()
        {
            Vector vector1 = new Vector { X = 1, Y = 2 };
            Vector vector2 = new Vector { X = 3, Y = 4 };
            Vector vector3 = new Vector { X = 4, Y = 6 };

            Segment s1 = new Segment { Begin = vector1, End = vector2 };

            Console.WriteLine($"Длина вектора = {vector1.GetLength()}");
            Console.WriteLine($"Длина сегмента = {s1.GetLength()}");
            Console.WriteLine($"Вектор v1 ({vector1.X}, {vector1.Y}) {(s1.Contains(vector1) ? "" : "не")} в сегменте.");
            Console.WriteLine($"Вектор v2 ({vector2.X}, {vector2.Y}) {(s1.Contains(vector2) ? "" : "не")} в сегменте.");
            Console.WriteLine($"Вектор v3 ({vector3.X}, {vector3.Y}) is {(vector3.Belongs(s1) ? "" : " не")} в сегменте.");

            Console.ReadLine();
        }
    }
}
