using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIPIS
{
    public partial class Optform : Form
    {
        public Optform()
        {
            InitializeComponent();
        }

        private void count_Click(object sender, EventArgs e)
        {
            double c1, c2, B1, B2;

            double[,] A = new double[2, 2] { { Convert.ToDouble(a11.Text), Convert.ToDouble(a12.Text) },
                                             { Convert.ToDouble(a21.Text), Convert.ToDouble(a22.Text) } };

            c1 = int.Parse(C1.Text); c2 = Convert.ToDouble(C2.Text);

            B1 = Convert.ToDouble(b1.Text); B2 = Convert.ToDouble(b2.Text);
            
            Main.Maximization(c1, c2, B1, B2, A, out double X, out double Y, out double P);

            MaxP.Text = "Максимальное значение P = " + P;
            MaxXY.Text = "достигается при X = " + X + ", Y = " + Y;
        }
    }
}
