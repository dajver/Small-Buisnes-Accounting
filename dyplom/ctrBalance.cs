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
    public partial class ctrBalance : Form
    {
        public ctrBalance()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void ctrBalance_Load(object sender, EventArgs e)
        {
            ReportBalance repB = new ReportBalance(this);
            repB.MdiParent = this;
            repB.Show();

            Thread serv1 = new Thread(serch);
            serv1.Start();
        }

        public string x1 = "";

        public void serch()
        {
                for (; ; )
                {
                    if (x1 == "exit")
                    {
                        break;
                    }
                    else
                    {
                        if (x1 != "" && x1 != "exit")
                        {
                            containCtrBox.Text = x1;
                            x1 = "";
                        }
                    }
                }
        }

        private void ctrBalance_FormClosed(object sender, FormClosedEventArgs e)
        {
            x1 = "exit";
        }
    }
}
