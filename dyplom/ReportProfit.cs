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
    public partial class ReportProfit : Form
    {
        public ReportProfit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int ran;
            ran = rand.Next(10000000);

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(bmp);
            Rectangle rt = new Rectangle(0,0, panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, rt);
            bmp.Save("blanks\\Profit_"+ran+".jpg");
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

