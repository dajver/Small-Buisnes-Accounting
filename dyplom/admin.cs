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

namespace dyplom
{
    public partial class admin : Form
    {
        private OleDbConnection Connection= null; 
        private List<User> use = new List<User>();
        public User CurrentUser = null;

        public admin()
        {
            InitializeComponent();
            try
            {

                this.Connection = new OleDbConnection();
                this.Connection.ConnectionString = "Provider = Microsoft.Jet.OleDb.4.0; Data Source = data.mdb";
                this.Connection.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT ID, FIO, Login, Password, Access FROM log");
                cmd.Connection = this.Connection;
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    use.Add(new User((int)reader["ID"], reader["FIO"].ToString(), reader["Login"].ToString(), reader["Password"].ToString(), reader["Access"].ToString()));
                };

                this.Connection.Close();
                loginTextBox.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            var query = (from user in this.use
                         where user.Login == loginTextBox.Text
                         select user).SingleOrDefault<User>();

            if (query == null)
            {
                label4.Text = "Неизвестный логин!";
                label4.ForeColor = System.Drawing.Color.Red;
                return;
            }
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Text = "Вы: " + query.FIO;

            this.CurrentUser = query as User;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm us = new MainForm();

                if (CurrentUser == null)
                {
                    return;
                };

                string InputPassword = this.passwordTextBox.Text;

                if (CurrentUser.Password != InputPassword)
                {
                    label4.Text = "Неверный пароль";
                    label4.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.CurrentUser.Password = "";
                    switch (CurrentUser.Access)
                    { 
                        case "Инспектор":
                            this.Hide();
                            us.MainMenuStrip.Items["fileToolStripMenuItem"].Visible = true;
                            us.MainMenuStrip.Items["показатьИнфоToolStripMenuItem1"].Visible = true;
                            us.MainMenuStrip.Items["информацияToolStripMenuItem"].Visible = true;
                            us.MainMenuStrip.Items["налоговаяОтчетностьToolStripMenuItem"].Visible = false;
                            us.MainMenuStrip.Items["управлениеПользователямиToolStripMenuItem"].Visible = false;
                            us.Show();
                            break;

                        case "Руководитель":
                            this.Hide();
                            us.MainMenuStrip.Items["fileToolStripMenuItem"].Visible = false;
                            us.MainMenuStrip.Items["показатьИнфоToolStripMenuItem1"].Visible = false;
                            us.MainMenuStrip.Items["информацияToolStripMenuItem"].Visible = true;
                            us.MainMenuStrip.Items["налоговаяОтчетностьToolStripMenuItem"].Visible = true;
                            us.MainMenuStrip.Items["управлениеПользователямиToolStripMenuItem"].Visible = false;
                            us.Show();
                            break;

                        case "Администратор":
                            this.Hide();
                            us.Show();
                            break;

                        default:
                            throw new Exception("Ошибка доступа");
                    }
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class User
    {
        public int ID;
        public string FIO;
        public string Login;
        public string Password;
        public string Access;

        public User(int ID, string FIO, string Login, string Password, string Access)
        {
            this.ID = ID;
            this.FIO = FIO;
            this.Login = Login;
            this.Password = Password;
            this.Access = Access;
        }
    }
}
