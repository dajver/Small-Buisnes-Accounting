using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Timers;
using System.Diagnostics;

namespace dyplom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string p)
        {
            this.p = p;
        }

        public OleDbConnection con = new OleDbConnection(); //коннект к базе
        public DataSet ds;                                 //Создание таблицы  
        public OleDbDataAdapter adapter;                   //запись данных в базу
        public OleDbCommand cmd = new OleDbCommand();      //событие записи в базу/файл
        private VocabDataSource Vocabs = null;
        private string p;

        private void re()
        {
            AddtoChina u = new AddtoChina();
            u.ds = ds;
            con.Close();
            u.con = con;
            u.cmd = cmd;
            u.ShowDialog();
        }

        private void AutoSave()
        {
            System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 780000;//780000;
            _timer.Tick += new EventHandler(save);
            _timer.Start();
        }

        private void save(Object Sender, EventArgs e)
        {
            try
            {
                string TableName = (dataGridView1.DataSource as DataTable).TableName;
                this.Vocabs.ApplyChanges(TableName);
            }

            catch
            {
                MessageBox.Show("Сохранение не возможно, поле сохранение пустое!", "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Provider = Microsoft.Jet.OleDb.4.0; Data Source = data.mdb";
                con.Open();

                cmd.Connection = con;

                this.Vocabs = new VocabDataSource(con);
                //
                //Счета юр лиц
                //
                this.Vocabs.Add("UrFace");
                //
                //Счета физ. лиц
                //
                this.Vocabs.Add("FizFace");
                //
                //
                //
                this.Vocabs.Add("log");

                this.dataGridView1.AutoGenerateColumns = false;

                //
                //BackUp DB
                //
                if (File.Exists("backup\\data_backup.mdb"))
                    this.Hide();
                else
                    File.Copy("data.mdb", "backup\\data_backup.mdb");

                AutoSave();
           }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void добавитьЮрЛицоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddtoChina u = new AddtoChina();
            u.Show();
        }

        private void редактироватьЮрЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin adm = new admin();
            adm.Show();
        }

        //
        //Сохранение в базу
        //

        private void Vocabl_Click(object sender, EventArgs e)
        {
            try
            {
                string TableName = (sender as ToolStripMenuItem).Tag.ToString();
                this.dataGridView1.Columns.Clear();
                DataTable dt = this.Vocabs.GetTable(TableName);

                foreach (DataColumn cl in dt.Columns)
                {
                    DataGridViewTextBoxColumn dc1 = new DataGridViewTextBoxColumn();
                    dc1.DataPropertyName = cl.ColumnName;
                    dc1.HeaderText = cl.Caption;
                    this.dataGridView1.Columns.Add(dc1);
                };
                this.dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        //Добавление пользователя
        //
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                addUser add = new addUser();
                add.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void добавитьЮрЛицоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddtoChina u = new AddtoChina();
            u.Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
        }

        private void сохранитьВБазуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string TableName = (dataGridView1.DataSource as DataTable).TableName;
                this.Vocabs.ApplyChanges(TableName);
                MessageBox.Show("Сохраненно");
            }

            catch
            {
                MessageBox.Show("Поле сохранения пустое, выберите один из пунктов и нажмите Сохранить в базу", "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (status == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void добавитьToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            ctrBalance ctrB = new ctrBalance();
            ctrB.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Container coten = new Container();
            coten.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportProfit rep = new ReportProfit();
            rep.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Process p = new Process();
                p.StartInfo.FileName = "winword.exe";
                p.StartInfo.Verb = "runas";
                p.StartInfo.Arguments = "instruction.doc";
                p.Start();
        }

        private void просмотретьВсеБланкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBlanks all = new AllBlanks();
            all.Show();
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0) { dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index); }
            string TableName = (dataGridView1.DataSource as DataTable).TableName;
            this.Vocabs.ApplyChanges(TableName);
        }
    }

    //
    //Класс сохранения в базу
    //
    class VocabDataSource
    {
        private OleDbConnection Connection = null;
        private Dictionary<string, OleDbDataAdapter> Tables = null;
        private DataSet VocabDataSet=null;
        public VocabDataSource(OleDbConnection Connection)
        {
            this.Connection = Connection;
            this.Tables = new Dictionary<string, OleDbDataAdapter>();
            this.VocabDataSet = new DataSet();
        }

        public void Add(string TableName)
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(String.Format("select * from {0}", TableName), this.Connection);
                OleDbCommandBuilder cd = new OleDbCommandBuilder(da);
                da.Fill(this.VocabDataSet, TableName);
                this.Tables.Add(TableName, da);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ApplyChanges(string TableName)
        {
            try
            {
                OleDbDataAdapter da;
                if (this.Tables.TryGetValue(TableName, out da))
                {
                    da.Update(VocabDataSet, TableName);
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable GetTable(string TableName)
        {
                return this.VocabDataSet.Tables[TableName];
        }
    }
}
