using System;
using System.Windows.Forms;

namespace TIPIS
{
    public partial class Stabform : Form
    {
        public static int num = 0;

        public Stabform()
        {
            InitializeComponent();
        }

        private void Stabform_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 1. Создание массива случайных значений
        /// 2. Анализ значений для стабилизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneMore_Click(object sender, EventArgs e)
        {
            num++;
            
            // Очистка полей для повторного использования
            if (num == 6)
            {
                num = 1;

                Output.Text = "Вывод 1: "; Output2.Text = "Вывод 2: "; Output3.Text = "Вывод 3: "; Output4.Text = "Вывод 4: "; Output5.Text = "Вывод 5: ";

                foreach (Control controls in this.Controls)
                {
                    if (controls is TextBox)
                    {
                        ((TextBox)controls).Clear();
                    }
                }
            }

            // Генерация значений
            Random R = new Random();
            double[] Mas = new double[100];
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = R.Next(200);
            }

            // Смена окна вывода (5 столбцов на форме)
            switch (num)
            {
                case 1:
                    Out(Middle, Dispersion, StOtkl, Output, Mas);
                    break;

                case 2:
                    Out(Middle2, Dispersion2, StOtkl2, Output2, Mas);
                    break;

                case 3:
                    Out(Middle3, Dispersion3, StOtkl3, Output3, Mas);
                    break;

                case 4:
                    Out(Middle4, Dispersion4, StOtkl4, Output4, Mas);
                    break;

                case 5:
                    Out(Middle5, Dispersion5, StOtkl5, Output5, Mas);
                    break;

                default:
                    break;
            }

            
        }

        /// <summary>
        /// Поиск среднего арифметического, детерминцаиии и стандартного отклонения
        /// на основе сгенерированного массива значений
        /// </summary>
        /// <param name="middle">TextBox среднего арифметического</param>
        /// <param name="dispersion">TextBox вывода дисперсии</param>
        /// <param name="stot">TextBox стандартного отклонения</param>
        /// <param name="output">Label вывода</param>
        /// <param name="Mas">Массив со значениями</param>
        private static void Out(TextBox middle, TextBox dispersion, TextBox stot, Label output, double[] Mas)
        {
            middle.Text = Convert.ToString(Main.Mid(Mas));
            dispersion.Text = Convert.ToString(Main.Disp(Mas));
            stot.Text = Convert.ToString(Main.Stot(Mas));
            output.Text += "y = " + Convert.ToString(Main.Mid(Mas)) + " ± " + Convert.ToString(Main.Stot(Mas));
        }
    }
}
