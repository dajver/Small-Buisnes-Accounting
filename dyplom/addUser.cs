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
using System.Data.OleDb;


namespace dyplom
{
    public partial class addUser : Form
    {
        private MainForm user = new MainForm();


        public addUser()
        {
            InitializeComponent();
        }

        public OleDbConnection con = new OleDbConnection(); //коннект к базе
        public DataSet ds;                                 //Создание таблицы  
        public OleDbDataAdapter adapter;                   //запись данных в базу
        public OleDbCommand cmd = new OleDbCommand();      //событие записи в базу/файл
        MainForm main = new MainForm();

        private void addUser_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.Jet.OleDb.4.0; Data Source = data.mdb";
            con.Open();
            cmd.Connection = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(); 
                cmd.Connection = con;
                DataSet ds = new DataSet();

                if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty && comboBox1.Text == string.Empty)
                {
                    MessageBox.Show("Ошибка! Возможно заполнены не все поля или не коректно введены данные.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.CommandText = "Insert Into log (FIO, [Login], [Password], Access) Values "
                                        + " ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                    OleDbDataAdapter ad = new OleDbDataAdapter("Select * From log", con);
                    ad.Fill(ds, "log");
                    main.dataGridView1.DataSource = ds.Tables["log"];

                    MessageBox.Show(@"Новый юзер добавлен", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch
            {
                MessageBox.Show("Ошибка! Возможно заполнены не все поля или не коректно введены данные.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
