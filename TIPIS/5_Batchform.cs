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
    public partial class Batchform : Form
    {
        public Batchform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] Mas = new double[150];
            double w = double.Parse(W.Text);
            Random r = new Random();
            double sum = 0, next = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                next = (double)r.Next(100) / 100;
                sum += next;
                Mas[i] = Math.Cos(w * Math.PI / 180 * i) + next;
            }
            sum /= Mas.Length;
            func.Text = "y = cos(" + W.Text + "*Pi/180*x)+" + Convert.ToString(sum);
            Period.Text = "Период функции = " + Main.Period(Mas);
        }
    }
}
