using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GeometryTasks;

namespace GeometryPainting
{
    internal static class Program
    {
        private static List<Segment> CreateSegments()
        {
            var result = new List<Segment>();
            for (var i = 0; i <= 255; i++)
            {
                var segment = new Segment
                {
                    Begin = new Vector { X = 0, Y = i },
                    End = new Vector { X = 255, Y = i }
                };
                result.Add(segment);
            }
            return result;
        }

        private static void DrawSegments(object sender, PaintEventArgs e)
        {
            var segments = CreateSegments();
            foreach (var segment in segments)
            {
                using (var pen = new Pen(Color.FromArgb((int)segment.Begin.Y, (int)segment.Begin.Y, (int)segment.Begin.Y)))
                {
                    e.Graphics.DrawLine(pen, (float)segment.Begin.X, (float)segment.Begin.Y,
                                             (float)segment.End.X, (float)segment.End.Y);
                }
            }
        }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form
            {
                ClientSize = new Size(255, 255),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };
            form.Paint += DrawSegments;
            Application.Run(form);
        }
    }
}
