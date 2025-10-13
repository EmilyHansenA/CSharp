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
}
