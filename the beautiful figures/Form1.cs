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

        public void SquareThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed visualisation of Square");
        }
        public void TriangleThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed visualisation of Triangle");
        }
        public void RectangleThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed visualisation of Rectangle");
        }
    }
}