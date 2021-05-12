using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPoint_Line
{
    public partial class Form1 : Form
    {
        private static Graphics grp;
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        static Random rnd = new Random();
        public class point
        {
            public float x, y;
            public point()
            {
                x = rnd.Next(900);
                y = rnd.Next(600);
            }
            public void Draw(Graphics grp)
            {
                grp.DrawEllipse(new Pen(Color.Red, 4), x, y, 4, 4);
            }
        }

        private List<point> points = new List<point>();

        private void Form1_Load(object sender, EventArgs e)
        {
            grp = pictureBox1.CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grp.Clear(Color.White);
            point newPoint = new point();
            string[] text = textBox1.Text.Split(new[] { ' ' });
            newPoint.x = Int32.Parse(text[0]);
            newPoint.y = Int32.Parse(text[1]);

            points.Add(newPoint);
            foreach (var p in points)
            {
                grp.FillEllipse(new SolidBrush(Color.Red), p.x, p.y, 4, 4);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < points.Count; i++)
            {
                grp.DrawLine(Pens.Black, points[i].x, points[i].y, points[i - 1].x, points[i - 1].y);
            }

            int len = points.Count;

            grp.DrawLine(Pens.Black, points[len - 1].x, points[len - 1].y, points[0].x, points[0].y);

            textBox1.Text = "";
        }
    }
}
