using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using ZedGraph;

namespace dyplom
{
    public partial class ReportBalance : Form
    {
        private dyplom.ctrBalance cont;

        public ReportBalance(dyplom.ctrBalance con)
        {
            InitializeComponent();
            cont = con;
        }

        #region Определение лейблов

        private void label75_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label75.Text;
        }

        private void label76_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label76.Text;
        }

        private void label77_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label77.Text;
        }

        private void label78_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label78.Text;
        }

        private void label79_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label79.Text;
        }

        private void label80_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label80.Text;
        }

        private void label81_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label81.Text;
        }

        private void label82_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label82.Text;
        }

        private void label83_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label83.Text;
        }

        private void label84_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label84.Text;
        }

        private void label85_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label85.Text;
        }

        private void label86_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label86.Text;
        }

        private void label87_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label87.Text;
        }

        private void label88_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label88.Text;
        }

        private void label89_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label81.Text;
        }

        private void label90_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label90.Text;
        }

        private void label91_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label91.Text;
        }

        private void label92_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label92.Text;
        }

        private void label93_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label93.Text;
        }

        private void label94_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label94.Text;
        }

        private void label95_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label95.Text;
        }

        private void label97_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label97.Text;
        }

        private void label98_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label98.Text;
        }

        private void label99_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label99.Text;
        }

        private void label100_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label100.Text;
        }

        private void label101_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label101.Text;
        }

        private void label102_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label102.Text;
        }

        private void label103_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label103.Text;
        }

        private void label104_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label104.Text;
        }

        private void label105_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label105.Text;
        }

        private void label106_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label106.Text;
        }

        private void label96_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label96.Text;
        }

        private void label18_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label18.Text;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label1.Text;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label2.Text;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label3.Text;
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label4.Text;
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label5.Text;
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label6.Text;
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label7.Text;
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label8.Text;
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label9.Text;
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label10.Text;
        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label11.Text;
        }

        private void label12_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label12.Text;
        }

        private void label13_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label13.Text;
        }

        private void label14_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label14.Text;
        }

        private void label15_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label15.Text;
        }

        private void label16_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label16.Text;
        }

        private void label17_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label17.Text;
        }

        private void label19_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label19.Text;
        }

        private void label20_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label20.Text;
        }

        private void label21_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label21.Text;
        }

        private void label22_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label22.Text;
        }

        private void label53_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label53.Text;
        }

        private void label52_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label52.Text;
        }

        private void label51_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label51.Text;
        }

        private void label50_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label50.Text;
        }

        private void label49_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label49.Text;
        }

        private void label48_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label48.Text;
        }

        private void label47_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label47.Text;
        }

        private void label46_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label46.Text;
        }

        private void label45_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label45.Text;
        }

        private void label44_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label44.Text;
        }

        private void label43_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label43.Text;
        }

        private void label42_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label42.Text;
        }

        private void label41_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label41.Text;
        }

        private void label40_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label40.Text;
        }

        private void label39_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label39.Text;
        }

        private void label38_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label38.Text;
        }

        private void label37_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label37.Text;
        }

        private void label36_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label36.Text;
        }

        private void label35_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label35.Text;
        }

        private void label34_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label34.Text;
        }

        private void label30_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label30.Text;
        }

        private void label31_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label31.Text;
        }

        private void label32_MouseClick(object sender, MouseEventArgs e)
        {
            cont.x1 = label32.Text;
        }

        #endregion

        private void button2_Click(object sender, EventArgs r)
        {
            Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);
            using (Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            {
                this.DrawToBitmap(bmp, rect);
                using (PrintDocument pd = new PrintDocument())
                {
                    pd.PrintPage += (obj, e) => { e.Graphics.DrawImage(bmp, rect); };
                    pd.Print();
                }
            }
        }

        #region Считака данных в тексбоксе
        private void textBox101_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox101.Text = (double.Parse(textBox103.Text) - double.Parse(textBox102.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox78_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox78.Text = (double.Parse(textBox80.Text) - double.Parse(textBox79.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox96_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox78.Text = (double.Parse(textBox101.Text) + double.Parse(textBox100.Text) + double.Parse(textBox99.Text) + double.Parse(textBox98.Text) + double.Parse(textBox97.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox83_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox83.Text = (double.Parse(textBox94.Text) + double.Parse(textBox93.Text) + double.Parse(textBox92.Text) + double.Parse(textBox91.Text) + double.Parse(textBox90.Text) + double.Parse(textBox87.Text) + double.Parse(textBox86.Text) + double.Parse(textBox85.Text) + double.Parse(textBox84.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox82_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox82.Text = (double.Parse(textBox96.Text) - double.Parse(textBox83.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox73_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox73.Text = (double.Parse(textBox78.Text) + double.Parse(textBox77.Text) + double.Parse(textBox75.Text) + double.Parse(textBox74.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox60_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox60.Text = (double.Parse(textBox71.Text) + double.Parse(textBox70.Text) + double.Parse(textBox69.Text) + double.Parse(textBox68.Text) + double.Parse(textBox67.Text) + double.Parse(textBox64.Text) + double.Parse(textBox63.Text) + double.Parse(textBox62.Text) + double.Parse(textBox61.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox59_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox59.Text = (double.Parse(textBox73.Text) - double.Parse(textBox60.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Graphic graph = new Graphic();
                graph.Show();

                GraphPane pane = graph.zedGraphControl1.GraphPane;
                pane.CurveList.Clear();
                pane.Title.Text = "Гистограмма бланка баланса";
                pane.YAxis.Title.Text = "За звітній період";
                pane.XAxis.Title.Text = "За аналогіч.  період попереднього року";
                Random rnd = new Random(100);

                double[] data = new double[] { Convert.ToInt32(textBox101.Text), Convert.ToInt32(textBox96.Text), Convert.ToInt32(textBox83.Text), Convert.ToInt32(textBox82.Text) };
                double[] data1 = new double[] { Convert.ToInt32(textBox78.Text), Convert.ToInt32(textBox73.Text), Convert.ToInt32(textBox60.Text), Convert.ToInt32(textBox59.Text) };

                double[] xvalues = new double[data.Length];
                double[] xvalues1 = new double[data1.Length];
                double[] yvalues = new double[data.Length];
                double[] yvalues1 = new double[data1.Length];

                for (int i = 0; i < data.Length; i++)
                {
                    // Значения по оси X
                    xvalues[i] = data[i];
                    // Высота столбиков
                    yvalues[i] = rnd.NextDouble();
                }
                for (int j = 0; j < data1.Length; j++)
                {
                    xvalues1[j] = data1[j];
                    yvalues1[j] = rnd.NextDouble();
                }

                BarItem curve = pane.AddBar("", xvalues, yvalues, Color.Red);
                BarItem curve1 = pane.AddBar("", xvalues1, yvalues1, Color.Green);

                //pane.BarSettings.MinClusterGap = 0.0f;

                graph.zedGraphControl1.AxisChange();
                graph.zedGraphControl1.Invalidate();
            }

            catch
            {
                MessageBox.Show(@"Возможно заполнены не все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int ran;
            ran = rand.Next(10000000);

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(bmp);
            Rectangle rt = new Rectangle(0, 0, panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, rt);
            bmp.Save("blanks\\Balance_"+ran+".jpg");
            MessageBox.Show(@"Бланк сохранен!", "Системное", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
