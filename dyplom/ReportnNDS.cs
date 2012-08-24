using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;
using ZedGraph;

namespace dyplom
{
    public partial class ReportnNDS : Form
    {
        private dyplom.Container contain;

        public ReportnNDS(dyplom.Container con)
        {
            InitializeComponent();
            contain = con;
        }
        
        #region Определение лейблов

        private void label93_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label93.Text;
        }

        private void label94_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label94.Text;
        }

        private void label95_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label95.Text;
        }

        private void label96_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label96.Text;
        }

        private void label97_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label97.Text;
        }

        private void label98_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label98.Text;
        }

        private void label99_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label99.Text;
        }

        private void label100_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label100.Text;
        }

        private void label101_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label101.Text;
        }

        private void label102_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label102.Text;
        }

        private void label103_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label103.Text;
        }

        private void label104_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label104.Text;
        }

        private void label105_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label105.Text;
        }

        private void label106_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label106.Text;
        }

        private void label107_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label107.Text;
        }

        private void label147_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label147.Text;
        }

        private void label148_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label148.Text;
        }

        private void label149_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label149.Text;
        }

        private void label150_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label150.Text;
        }

        private void label151_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label151.Text;
        }

        private void label152_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label152.Text;
        }

        private void label153_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label153.Text;
        }

        private void label154_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label154.Text;
        }

        private void label155_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label155.Text;
        }

        private void label156_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label156.Text;
        }

        private void label157_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label156.Text;
        }

        private void label158_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label158.Text;
        }

        private void label159_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label159.Text;
        }

        private void label160_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label160.Text;
        }

        private void label161_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label161.Text;
        }

        private void label162_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label162.Text;
        }

        private void label163_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label163.Text;
        }

        private void label164_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label164.Text;
        }

        private void label165_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label165.Text;
        }

        private void label166_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label166.Text;
        }

        private void label168_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label168.Text;
        }

        private void label169_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label169.Text;
        }

        private void label170_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label170.Text;
        }

        private void label141_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label171.Text;
        }

        private void label171_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label171.Text;
        }

        private void label172_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label172.Text;
        }

        private void label173_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label173.Text;
        }

        private void label174_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label174.Text;
        }

        private void label175_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label175.Text;
        }

        private void label176_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label177.Text;
        }

        private void label182_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label182.Text;
        }

        private void label183_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label183.Text;
        }

        private void label197_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label197.Text;
        }

        private void label198_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label198.Text;
        }

        private void label199_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label199.Text;
        }

        private void label200_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label200.Text;
        }

        private void label201_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label201.Text;
        }

        private void label202_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label202.Text;
        }

        private void label203_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label203.Text;
        }

        private void label204_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label204.Text;
        }

        private void label205_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label205.Text;
        }

        private void label206_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label206.Text;
        }

        private void label207_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label207.Text;
        }

        private void label208_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label200.Text;
        }

        private void label209_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label209.Text;
        }

        private void label210_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label210.Text;
        }

        private void label213_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label213.Text;
        }

        private void label214_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label214.Text;
        }

        private void label215_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label215.Text;
        }

        private void label216_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label216.Text;
        }

        private void label219_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label219.Text;
        }

        private void label218_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label218.Text;
        }

        private void label217_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label217.Text;
        }

        private void label221_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label221.Text;
        }

        private void label222_MouseClick(object sender, MouseEventArgs e)
        {
            contain.x = label222.Text;
        }

        #endregion

        #region Обрааботчик прятанья
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (urFace_rButton.Checked == true)
            {
                label26.Visible = true;
                textBox17.Visible = true;
                label27.Visible = true;
                comboBox1.Visible = true;
                textBox30.Visible = true;
                textBox205.Visible = true;
                textBox206.Visible = true;
                textBox203.Visible = true;
            }
            else
            {
                label26.Visible = false;
                textBox17.Visible = false;
                label27.Visible = false;
                comboBox1.Visible = false;
                textBox30.Visible = false;
                textBox205.Visible = false;
                textBox206.Visible = false;
                textBox203.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (fizFace_rButton.Checked == true)
            {
                label29.Visible = true;
                textBox18.Visible = true;
                label28.Visible = true;
                comboBox2.Visible = true;
                textBox176.Visible = true;
                textBox208.Visible = true;
                textBox209.Visible = true;
                textBox211.Visible = true;
                //
                //Платник податку на додану вартысть
                //
                label240.Visible = true;
                label239.Visible = true;
                textBox207.Visible = true;
                label237.Visible = true;
                label238.Visible = true;
                textBox204.Visible = true;
                label236.Visible = true;
            }
            else
            {
                label29.Visible = false;
                textBox18.Visible = false;
                label28.Visible = false;
                comboBox2.Visible = false;
                textBox176.Visible = false;
                textBox208.Visible = false;
                textBox211.Visible = false;
                textBox209.Visible = false;
                //
                //Платник податку на додану вартысть
                //
                label240.Visible = false;
                label239.Visible = false;
                textBox207.Visible = false;
                label237.Visible = false;
                label238.Visible = false;
                textBox204.Visible = false;
                label236.Visible = false;
            }
        }
        #endregion

        private void ReportnNDS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.UrFace' table. You can move, or remove it, as needed.
            this.urFaceTableAdapter.Fill(this.dataDataSet.UrFace);
            // TODO: This line of code loads data into the 'dataDataSet.FizFace' table. You can move, or remove it, as needed.
            this.fizFaceTableAdapter.Fill(this.dataDataSet.FizFace);
            

        }

        #region Счет в текстбоксах

        private void textBox135_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox135.Text = (double.Parse(textBox144.Text) + double.Parse(textBox138.Text) + double.Parse(textBox146.Text) + double.Parse(textBox133.Text) + double.Parse(textBox124.Text) + double.Parse(textBox122.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox175_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox175.Text = (double.Parse(textBox159.Text) + double.Parse(textBox151.Text) + double.Parse(textBox150.Text) + double.Parse(textBox148.Text) + double.Parse(textBox161.Text) + double.Parse(textBox158.Text)).ToString();
            }

            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox191_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox191.Text = (double.Parse(textBox177.Text) + double.Parse(textBox178.Text) + double.Parse(textBox179.Text) + double.Parse(textBox180.Text) + double.Parse(textBox181.Text) + double.Parse(textBox182.Text)).ToString();
            }

            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox190_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox190.Text = (double.Parse(textBox186.Text) + double.Parse(textBox187.Text)).ToString();
            }

            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox187_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox187.Text = (double.Parse(textBox188.Text) + double.Parse(textBox189.Text)).ToString();
            }

            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox186_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox186.Text = (double.Parse(textBox182.Text) - double.Parse(textBox177.Text)).ToString();
            }

            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox122_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox122.Text = (double.Parse(textBox121.Text) + double.Parse(textBox119.Text) + double.Parse(textBox137.Text) + double.Parse(textBox136.Text) + double.Parse(textBox85.Text)).ToString();
            }

            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox158_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox158.Text = (double.Parse(textBox156.Text) + double.Parse(textBox171.Text) + double.Parse(textBox173.Text) + double.Parse(textBox174.Text) + double.Parse(textBox116.Text)).ToString();
            }

            catch
            {
                MessageBox.Show("Ошибка! Введены не коректные данные или поля пустые", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Graphic graph = new Graphic();
                graph.Show();

                GraphPane pane = graph.zedGraphControl1.GraphPane;
                pane.CurveList.Clear();
                pane.Title.Text = "Гистограмма бланка НДС";
                pane.YAxis.Title.Text = "Обсяги постачання";
                pane.XAxis.Title.Text = "Сума податку на  додану вартість";
                Random rnd = new Random(100);

                double[] data = new double[] { Convert.ToInt32(textBox135.Text), Convert.ToInt32(textBox122.Text)};
                double[] data1 = new double[] { Convert.ToInt32(textBox175.Text), Convert.ToInt32(textBox158.Text) };
                double[] data2 = new double[] { Convert.ToInt32(textBox175.Text), Convert.ToInt32(textBox158.Text) };

                double[] xvalues = new double[data.Length];
                double[] xvalues1 = new double[data1.Length];
                double[] xvalues2 = new double[data2.Length];
                double[] yvalues = new double[data.Length];
                double[] yvalues1 = new double[data1.Length];
                double[] yvalues2 = new double[data2.Length];

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
                for (int j = 0; j < data1.Length; j++)
                {
                    xvalues2[j] = data2[j];
                    yvalues2[j] = rnd.NextDouble();
                }
                BarItem curve = pane.AddBar("", xvalues, yvalues, Color.Blue);
                BarItem curve1 = pane.AddBar("", xvalues1, yvalues1, Color.Red);
                BarItem curve2 = pane.AddBar("", xvalues2, yvalues2, Color.Green);

                pane.BarSettings.MinClusterGap = 0.0f;

                graph.zedGraphControl1.AxisChange();
                graph.zedGraphControl1.Invalidate();
            }

            catch
            {
                MessageBox.Show(@"Возможно заполнены не все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            int ran;
            ran = rand.Next(10000000);

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(bmp);
            Rectangle rt = new Rectangle(0, 0, panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, rt);
            bmp.Save("blanks\\NDS_"+ran+".jpg");
            MessageBox.Show(@"Бланк сохранен!", "Системное", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs r)
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
    }
}
