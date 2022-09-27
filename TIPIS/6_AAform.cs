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
    public partial class AAform : Form
    {
        public AAform()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            double[] Data = new double[15];
            double[] Output;
            Random R = new Random();
            for (int i = 0; i < Data.Length; i++)
            {
                Data[i] = R.Next(100);
            }
            Output = Main.Forecasting(Data);
                
            real.Text = "Реальные значения функции: ";
            forecast.Text = "Спрогнозированные значения функции: ";
            for (int i = 0; i < Data.Length; i++)
            {
                real.Text += Convert.ToString(Data[i]) + " ";
                forecast.Text += Convert.ToString(Output[i]) + " ";
            }
            determine.Text = "Коэффициент детерминации = " + Main.Determination(Data, Output);
        }
    }
}
