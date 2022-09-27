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
    public partial class Synthform : Form
    {
        public static int n = 0;
        public Random R = new Random();
        public Synthform()
        {
            InitializeComponent();
        }

        private void count_Click(object sender, EventArgs e)
        {
            n++;
            
            //обнуление счётчика  для корректной работы при повторном использовании полей
            if (n > 3)
            {
                n = 1;
            }

            double[] mas1 = new double[15], mas2 = new double[15];
            mas1[0] = 0; mas2[0] = 0;

            // Заполнение полей 1-3
            switch (n)
            {
                case 1:
                    Case(mas1a, mas1b, out1, mas1, mas2);
                    break;

                case 2:
                    Case(mas2a, mas2b, out2, mas1, mas2);
                    break;

                case 3:
                    Case(mas3a, mas3b, out3, mas1, mas2);
                    break;

                default:
                break;
            }
        }

        /// <summary>
        /// Генерация массивов и рассчет взаимосвязи их значений
        /// </summary>
        /// <param name="MasA">Label значений первого массива</param>
        /// <param name="MasB">Label значений второго массива</param>
        /// <param name="output">Label значений полученного сравнения массивов</param>
        /// <param name="Mas1"></param>
        /// <param name="Mas2"></param>
        private void Case(Label MasA, Label MasB, Label output, double[] Mas1, double[] Mas2)
        {
            MasA.Text = "Массив А";
            MasB.Text = "Массив Б";
            for (int i = 1; i < 15; i++)
            {
                Mas1[i] = Mas1[i - 1] + R.Next(9);
                MasA.Text += " " + Convert.ToString(Mas1[i]) + " ";

                Mas2[i] = Mas2[i - 1] + R.Next(9);
                MasB.Text += " " + Convert.ToString(Mas2[i]) + " ";
            }
            output.Text = "Коэффициент корреляции между массивами равен " +
                        Convert.ToString(Main.Korr(Mas1, Mas2)) + " вероятность ошибки " +
                        Convert.ToString(Main.Cov(Mas1, Mas2));
        }
    }
}
