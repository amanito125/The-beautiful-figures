using System.Drawing;
using System.Threading;

namespace the_beautiful_figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        Thread th1;
        Thread th2;
        Thread th3;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            th2 = new Thread(RectangleThread);
            th2.Start();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            th1 = new Thread(TriangleThread);
            th1.Start();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            th = new Thread(SquareThread);
            th.Start();
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            th3 = new Thread(CircleThread);
            th3.Start();
        }

        public void SquareThread()
        {
            int randomNum = new Random().Next(1, 10);
            for (int i = 0; i < randomNum; i++)
            {
                Random rnd = new Random();
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                int n = new Random().Next(20, 170);
                this.CreateGraphics().DrawRectangle(new Pen(randomColor, 4), new Rectangle(new Random().Next(0, this.Width), new Random().Next(0, this.Height), n, n));
                Thread.Sleep(1000);
            }
            MessageBox.Show("Completed visualisation of Square! Created squares " + randomNum);
        }
        public void TriangleThread()
        {
            
            int randomNum = new Random().Next(1, 10);
            for (int i = 0; i < randomNum; i++)
            {
                Random rnd = new Random();
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                int n = new Random().Next(20, 170);
                this.CreateGraphics().DrawRectangle(new Pen(randomColor, 4), new Rectangle(new Random().Next(0, this.Width), new Random().Next(0, this.Height), n, n));
                Thread.Sleep(2000);
            }
            MessageBox.Show("Completed visualisation of Triangle! Created triangles " + randomNum);
        }
        public void RectangleThread()
        {
            int randomNum = new Random().Next(1, 10);
            for (int i = 0; i < randomNum; i++)
            {
                Random rnd = new Random();
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                int b = new Random().Next(20, 170);
                int n = new Random().Next(20, 170);
                this.CreateGraphics().DrawRectangle(new Pen(randomColor, 4), new Rectangle(new Random().Next(0, this.Width), new Random().Next(0, this.Height), n, b));
                Thread.Sleep(3000);
            }
            MessageBox.Show("Completed visualisation of Rectangle! Created rectangle: " + randomNum);
        }

        public void CircleThread()
        {
            int randomNum = new Random().Next(1, 10);
            for (int i = 0; i < randomNum; i++)
            {
                Random rnd = new Random();
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                int n = new Random().Next(20, 170);
                this.CreateGraphics().DrawEllipse(new Pen(randomColor, 4), new Random().Next(0, this.Width), new Random().Next(0, this.Height), n, n);
                Thread.Sleep(4000);
            }
            MessageBox.Show("Completed visualisation of Circle! Created rectangle: " + randomNum);
        }
    }
}