using System;
using System.Windows.Forms;

namespace TIPIS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// стабилизация процессов, когда необходимо контролировать значения
        /// некоторого параметра в определенной зоне
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stabilization_Click(object sender, EventArgs e) //LAB1
        {
            Stabform form = new Stabform();
            form.ShowDialog(this); 
        }

        /// <summary>
        /// Анализ взаимосвязи различных массивов данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Synthesis_Click(object sender, EventArgs e) //LAB2
        {
            Synthform form = new Synthform();
            form.ShowDialog(this);
        }

        private void Analysis_Click(object sender, EventArgs e) //LAB3
        {
            Analysisform form = new Analysisform();
           form.ShowDialog(this);
        }

        private void Optimization_Click(object sender, EventArgs e) //LAB4
        {
            Optform form = new Optform();
            form.ShowDialog(this);
        }

        private void Batch_processes_Click(object sender, EventArgs e) //LAB5
        {
            Batchform form = new Batchform();
            form.ShowDialog(this);
        }

        private void AA_model_Click(object sender, EventArgs e) //LAB6
        {
            AAform form = new AAform();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Рассчет среднего арифметического
        /// </summary>
        /// <param name="Mas">Массив значений</param>
        /// <returns></returns>
        public static double Mid(double[] Mas)
        {
            double mid = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                mid += Mas[i];
            }

            mid /= Mas.Length;
            return mid;
        }

        /// <summary>
        /// Рассчет дисперсии
        /// </summary>
        /// <param name="Mas">массив значний</param>
        /// <returns></returns>
        public static double Disp(double[] Mas)
        {
            double disp = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                disp += Math.Pow((Mas[i] - Mid(Mas)), 2);
            }
            disp /= (Mas.Length - 1);
            return disp;
        }

        /// <summary>
        /// Рассчет среднеквадратичного (стандартного) отклонения
        /// </summary>
        /// <param name="Mas">массив значний</param>
        /// <returns></returns>
        public static double Stot(double[] Mas)
        {
            double stot = Math.Pow(Disp(Mas), 0.5);
            return stot;
        }

        /// <summary>
        /// Рассчет ковариации между двумя массивами значений (от 0 до 1)
        /// </summary>
        /// <param name="Mas">Массив (исходных) значений</param>
        /// <param name="Mas2">Массив (спрогнозированных) значений</param>
        /// <returns></returns>
        public static double Cov(double[] Mas, double[] Mas2)
        {
            double cov = 0; 

            for (int i = 0; i < Mas.Length; i++)
            {
                cov += Mas[i]*Mas2[i];
            }

            cov = cov / Mas.Length - Mid(Mas)*Mid(Mas2);

            return cov;
        }

        /// <summary>
        /// Рассчет коэффициента корреляции (зависимости) массивов значений (от -1 до +1)
        /// </summary>
        /// <param name="Mas">Массив (исходных) значений</param>
        /// <param name="Mas2">Массив (спрогнозированных) значений</param>
        /// <returns></returns>
        public static double Korr(double[] Mas, double[] Mas2)
        {
            double kor = Cov(Mas, Mas2) / (Stot(Mas) * Stot(Mas2));

            return kor;
        }

        /// <summary>
        /// Рассчет периода функции
        /// </summary>
        /// <param name="Mas">Массив значений функции</param>
        /// <returns>Значение периода функции</returns>
        public static double Period(double[] Mas)
        {
            double period;
            int c = Mas.Length / 2 + 8;
            double MasKor = -2, MinKor = 2;
            int min=0, max=0;
            double[] ZeroMas = new double[Mas.Length - c];
            double[] LagMas = new double[Mas.Length - c];

            for (int i = 0; i < Mas.Length - c; i++)
            {
                ZeroMas[i] = Mas[i + c];
                LagMas[i] = Mas[i + c - 1];
            }

            MasKor = Korr(ZeroMas, LagMas);
            MinKor = Korr(ZeroMas, LagMas);

            for (int j = 1; j < c; j++)
            {
                for (int i = 0; i < Mas.Length - c; i++)
                {
                    LagMas[i] = Mas[i + c -j- 1];
                }

                if (MasKor < Korr(ZeroMas, LagMas))
                {
                    MasKor = Korr(ZeroMas, LagMas);
                    max = j;
                }

                if (MinKor > Korr(ZeroMas, LagMas))
                {
                    MinKor = Korr(ZeroMas, LagMas);
                    min = j;
                }

            }
            period = (max - min) * 2;
            return period;
        }

        /// <summary>
        /// Прогнозирование значений методом наименьших квадратов
        /// </summary>
        /// <param name="MasY">Массив значений по оси Y</param>
        /// <param name="MasX">Массив значений по оси X</param>
        /// <returns>Массив спрогнозированных значений</returns>
        public static void MinSqrt(int[] MasY, int[] MasX, out double k, out double b)
        {
            k = 0; b = 0;

            double[,] MasXEd = new double[MasY.Length, 2];
            double[,] MasXTR = new double[2, MasY.Length];

            double[,] MasXObr = new double[2, 2];

            double[] MasXTRY = new double[2];

            for (int i = 0; i < MasY.Length; i++)
            {
                MasXEd[i, 0] = MasX[i];
                MasXEd[i, 1] = 1;

                MasXTR[0, i] = MasX[i];
                MasXTR[1, i] = 1;
            }

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int l = 0; l < MasX.Length; l++)
                    {
                        MasXObr[i, j] += MasXTR[i,l] * MasXEd[l,j];
                    }

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < MasX.Length; j++)
                {
                    MasXTRY[i] += MasXTR[i, j] * MasY[j];
                }

            //обратная матрица
            double Det = MasXObr[0, 0] * MasXObr[1, 1] - MasXObr[1, 0] * MasXObr[0, 1];
            double temp = MasXObr[1, 1];
            Det = 1 / Det;
            MasXObr[1, 1] = Det * MasXObr[0, 0];
            MasXObr[0, 0] = Det * temp;
            MasXObr[0, 1] = -1 * Det * MasXObr[0, 1];
            MasXObr[1, 0] = -1 * Det * MasXObr[1, 0];

            for (int j = 0; j < 2; j++)
            {
                k += MasXObr[0, j] * MasXTRY[j];
            }

            for (int j = 0; j < 2; j++)
            {
                b += MasXObr[1, j] * MasXTRY[j];
            }
        }

        /// <summary>
        /// Рассчет максимального значения P при изменяемых значениях X и Y,
        /// а также неизменных прочих параметрах
        /// </summary>
        /// <param name="C1">стоимость изделий 1</param>
        /// <param name="C2">стоимость изделий 2</param>
        /// <param name="B1">количество материала 1 в запасе для изделий</param>
        /// <param name="B2">количество материала 2 в запасе для изделий</param>
        /// <param name="A">количество расходного материала всех типов для одной единицы каждого из типов изделий</param>
        /// <param name="X">выходной параметр количества изделий 1</param>
        /// <param name="Y">выходной параметр количества изделий 2</param>
        /// <param name="P">Максимальная выручка</param>
        public static void Maximization(double C1, double C2, double B1, double B2, double[,] A, 
                                            out double X, out double Y, out double P)
        {
            double max = 0, x = 0;
            double max1 = C1 / A[0, 0], max2 = C2 / A[1, 0],
                   max3 = (B1 - A[0, 0] * x) / A[0, 1], max4 = (B2 - A[1, 0] * x) / A[1, 1];

            X = 0; Y = 0;

            for (x = 0; x<=max1 && x<=max2; x++)
            {
                for (double y = 0; y<=max1 && y<= max2; y++)
                {
                    if (C1 * x + C2 * y > max)
                    {
                        max = C1 * x + C2 * y;
                        Y = y;
                        X = x;
                    }
                }
            }
            P = max;
        }

        /// <summary>
        /// Рассчет коэффициента детерминации между исходным массивом данных и спрогнозированным
        /// </summary>
        /// <param name="Mas">Исходный массив данных</param>
        /// <param name="Forecast">Прогноз</param>
        /// <returns>Значение коэффициента</returns>
        public static double Determination(double[] Mas, double[] Forecast)
        {
            double Determiner;
            double prog = 0, mid = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                prog += Math.Pow((Mas[i] - Forecast[i]), 2);
                mid += Math.Pow((Mas[i] - Mid(Mas)), 2);
            }
            Determiner = 1 - (prog / mid);
            return Determiner;
        }

        /// <summary>
        /// Прогнозирование значений массива на основе предыдущих значений
        /// методом аппроксимации линейной функцией
        /// </summary>
        /// <param name="Mas"></param>
        /// <returns></returns>
        public static double[] Forecasting(double[] Mas)
        {
            double[] Future = new double[Mas.Length];
            double k=0, b=0;
            Future[0] = 0; Future[1] = 0;
            for (int i = 2; i < Mas.Length; i++)
            {
                k = (Mas[i-1]-Mas[i-2]);
                b = Mas[i - 2] - k * (i - 2);
                Future[i] = k * i + b;
            }
            return Future;
        }
    }
}
