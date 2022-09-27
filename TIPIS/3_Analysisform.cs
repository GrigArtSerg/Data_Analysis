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
    public partial class Analysisform : Form
    {
        public Analysisform()
        {
            InitializeComponent();
        }

        private void counter_Click(object sender, EventArgs e)
        {
            Y_Out.Text = "Массив Y:";
            T_Out.Text = "Массив T:";

            Random R = new Random();
            int[] MasY = new int[25];
            int[] MasT = new int[MasY.Length];

            double K, B;

            for (int i = 0; i < MasY.Length; i++)
            {
                MasY[i] = R.Next(10, 99);
                MasT[i] = i+1;

                Y_Out.Text += "  " + Convert.ToString(MasY[i]);
                if(MasT[i]<10)
                    T_Out.Text += "  _" + Convert.ToString(MasT[i]);
                else
                    T_Out.Text += "  " + Convert.ToString(MasT[i]);
            }

            Main.MinSqrt(MasY, MasT, out K, out B);

            Output.Text = "Массив данных апроксимируется прямой Y = " + K + " * T + " + B;
        }
    }
}
