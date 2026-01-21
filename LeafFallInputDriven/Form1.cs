using System;
using System.Drawing;
using System.Windows.Forms;

namespace LeafFallInputDriven
{
    public partial class Form1 : Form
    {
        // Вектор
        struct Vector
        {
            public double x, y, w;

            public Vector(double x, double y)
            {
                this.x = x;
                this.y = y;
                this.w = 1;
            }
        }

        double angle = 0;   // текущий угол
        int fall = 0;       // падение
        int dir = 1;        // направление колебаний

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            KeyPreview = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                angle += 10 * dir;
                fall += 5;
            }

            if (e.KeyCode == Keys.Right)
            {
                angle -= 10 * dir;
                fall += 5;
            }

            if (Math.Abs(angle) >= 60)
                dir *= -1;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(Color.LightSkyBlue);

            int px = Width / 2;
            int py = 0;

            // Листок векторы модель
            Vector[] leaf =
            {
                new Vector(-20, 40),
                new Vector(0, 20),
                new Vector(20, 40),
                new Vector(0, 80)
            };

            Vector[] stick =
            {
                new Vector(0, 80),
                new Vector(0, 120)
            };

            // Мастабирование
            double scale = 1.0 + fall / 100.0;

            // Матрица масштаба
            double[,] scaleMatrix = new double[3, 3]
            {
                { scale, 0,     0 },
                { 0,     scale, 0 },
                { 0,     0,     1 }
            };

            // Поворот
            double rad = angle * Math.PI / 180.0;

            // Матрица поворота
            double[,] rotateMatrix = new double[3, 3]
            {
                {  Math.Cos(rad), -Math.Sin(rad), 0 },
                {  Math.Sin(rad),  Math.Cos(rad), 0 },
                {  0,              0,             1 }
            };

            // Матрица падения
            double[,] translateMatrix = new double[3, 3]
            {
                { 1, 0, px },
                { 0, 1, py + fall },
                { 0, 0, 1 }
            };

            PointF[] leafPoints = new PointF[leaf.Length];
            for (int i = 0; i < leaf.Length; i++)
            {
                Vector v = leaf[i];
                v = ApplyMatrix(scaleMatrix, v);
                v = ApplyMatrix(rotateMatrix, v);
                v = ApplyMatrix(translateMatrix, v);

                leafPoints[i] = new PointF((float)v.x, (float)v.y);
            }

            PointF[] stickPoints = new PointF[stick.Length];
            for (int i = 0; i < stick.Length; i++)
            {
                Vector v = stick[i];
                v = ApplyMatrix(scaleMatrix, v);
                v = ApplyMatrix(rotateMatrix, v);
                v = ApplyMatrix(translateMatrix, v);

                stickPoints[i] = new PointF((float)v.x, (float)v.y);
            }

            // Затемнение листа
            double k = 1.0 - fall / 500.0;
            if (k < 0.3) k = 0.3;

            int green = (int)(150 * k);
            Brush leafBrush = new SolidBrush(Color.FromArgb(0, green, 0));

            g.FillPolygon(leafBrush, leafPoints);
            g.DrawLine(new Pen(Color.SaddleBrown, 3), stickPoints[0], stickPoints[1]);
        }

        //Умножение матрицы на вектор
        Vector ApplyMatrix(double[,] m, Vector v)
        {
            double x = m[0, 0] * v.x + m[0, 1] * v.y + m[0, 2] * v.w;

            double y = m[1, 0] * v.x + m[1, 1] * v.y + m[1, 2] * v.w;
            return new Vector(x, y);
        }
    }
}