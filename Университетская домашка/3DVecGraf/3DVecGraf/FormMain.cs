using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DVecGraf
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Paint += FormMain_Paint;
        }
        Graphics g;
        public void Draw()
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            g.DrawEllipse(Pens.Black, 200, 150, 100, 100);
            g.Dispose();
        }
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }
    }
}