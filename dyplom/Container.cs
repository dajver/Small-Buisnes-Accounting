using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace dyplom
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Container_Load(object sender, EventArgs e)
        {
            ReportnNDS repN = new ReportnNDS(this);
            repN.MdiParent = this;
            repN.Show();

            Thread serv = new Thread(serch);
            serv.Start();
        }

        public string x = "";

        public void serch()
        {
            for (; ; )
            {
                if (x == "exit")
                {
                    break;
                }
                else
                {
                    if (x != "" && x!="exit")
                {
                    containerBox.Text = x;
                    x = "";
                }
                }
            }

        }

        public void Container_FormClosed(object sender, FormClosedEventArgs e)
        {
            x ="exit";
        }
    }
}
