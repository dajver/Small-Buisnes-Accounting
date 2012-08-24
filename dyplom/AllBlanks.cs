using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace dyplom
{
    public partial class AllBlanks : Form
    {
        public AllBlanks()
        {
            InitializeComponent();
            //panel1.AutoScroll = true;
            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void AllBlanks_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("blanks");
            foreach (FileInfo files in dir.GetFiles())
                listView1.Items.Add(files.Name);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "blanks\\"+ listView1.FocusedItem.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs r)
        {
            Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
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
