using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace dyplom
{
    public partial class AddtoChina : Form
    {
        public AddtoChina()
        {
            InitializeComponent();
        }

        public OleDbConnection con = new OleDbConnection(); //коннект к базе
        public DataSet ds;                                 //Создание таблицы  
        public OleDbDataAdapter adapter;                   //запись данных в базу
        public OleDbCommand cmd = new OleDbCommand();      //событие записи в базу/файл
        MainForm main = new MainForm();

        private void ur_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Provider = Microsoft.Jet.OleDb.4.0; Data Source = data.mdb";
                con.Open();
                cmd.Connection = con;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    string ss = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
                    string s = textBox21.Text + "/" + textBox24.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "Insert Into UrFace ([ERDPOU], ShortName, Latin, FullName, FilialCode, [Date], [CertifNumber], [Organ], [FormaVlasnosti], [OrgPravForma], "
                        + " [Country], [MailIndex], [Oblast], [Distric], [City], [PhoneCode], [CityDistric], [Street], [StreetType],"
                        + " [House], [Korpus], [AppOffice], [Email], [WWWadress], [Other], [Number], [AccountType], [Valute], [Bank],"
                        + " [IDManager], [FIOManager], [ManagerPosition], [PhoneCompManager], [HomePhoneManager],"
                        + " [IDAccoutant], [FIOAccoutant], [PositionOfAccoutant], [CompPhonAcc], [HomePhoneAcc]) "
                        + " Values (" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox20.Text + "', '" + textBox4.Text + "', "
                        + "#" + ss + "#, " + textBox6.Text + ", '" + textBox7.Text + "', "
                        + " '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', " + textBox11.Text + ", "
                        + " '" + textBox12.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "', " + textBox15.Text + ", "
                        + " '" + textBox17.Text + "', " + textBox18.Text + ", '" + textBox19.Text + "', "
                        + " " + s + ", '" + textBox22.Text + "', '" + textBox23.Text + "', '" + textBox27.Text + "', '" + textBox26.Text + "', '" + textBox25.Text + "', "
                        + " '" + textBox31.Text + "', '" + textBox30.Text + "', '" + textBox29.Text + "', '" + textBox28.Text + "', "
                        + " " + textBox32.Text + ", '" + textBox33.Text + "', '" + textBox34.Text + "', " + textBox38.Text + ", "
                        + " " + textBox39.Text + ", " + textBox35.Text + ", '" + textBox36.Text + "', '" + textBox37.Text + "', "
                        + " " + textBox40.Text + ", " + textBox41.Text + ")";

                    cmd.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    OleDbDataAdapter ad = new OleDbDataAdapter("Select * From UrFace", con);
                    ad.Fill(ds, "UrFace");
                    main.dataGridView1.DataSource = ds.Tables["UrFace"];
                }
                else
                {
                    string ss = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
                    string s = textBox21.Text + "/" + textBox24.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "Insert Into FizFace (IDCode, ShortName, Latin, FullName, FilialCode, [Date], [CertifNumber], [Organ], [FormaVlasnosti], [OrgPravForma], "
                        + " [Country], [MailIndex], [Oblast], [Distric], [City], [PhoneCode], [CityDistric], [Street], [StreetType],"
                        + " [House], [Korpus], [AppOffice], [Email], [WWWadress], [Other], [Number], [AccountType], [Valute], [Bank],"
                        + " [IDManager], [FIOManager], [ManagerPosition], [PhoneCompManager], [HomePhoneManager],"
                        + " [IDAccoutant], [FIOAccoutant], [PositionOfAccoutant], [CompPhonAcc], [HomePhoneAcc]) "
                        + " Values (" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox20.Text + "', '" + textBox4.Text + "', "
                        + "#" + ss + "#, " + textBox6.Text + ", '" + textBox7.Text + "', "
                        + " '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', " + textBox11.Text + ", "
                        + " '" + textBox12.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "', " + textBox15.Text + ", "
                        + " '" + textBox17.Text + "', " + textBox18.Text + ", '" + textBox19.Text + "', "
                        + " " + s + ", '" + textBox22.Text + "', '" + textBox23.Text + "', '" + textBox27.Text + "', '" + textBox26.Text + "', '" + textBox25.Text + "', "
                        + " '" + textBox31.Text + "', '" + textBox30.Text + "', '" + textBox29.Text + "', '" + textBox28.Text + "', "
                        + " " + textBox32.Text + ", '" + textBox33.Text + "', '" + textBox33.Text + "', " + textBox38.Text + ", "
                        + " " + textBox39.Text + ", " + textBox35.Text + ", '" + textBox36.Text + "', '" + textBox37.Text + "', "
                        + " " + textBox40.Text + ", " + textBox41.Text + ")";

                    cmd.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    OleDbDataAdapter ad = new OleDbDataAdapter("Select * From FizFace", con);
                    ad.Fill(ds, "FizFace");
                    main.dataGridView1.DataSource = ds.Tables["FizFace"];
                }

                MessageBox.Show(@"Информация сохранена в базе", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Ошибка! Возможно заполнены не все поля или введены не верные данные.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "ЄРДПОУ";

            if (radioButton1.Checked == true)
            {
                label42.Visible = false;
                textBox4.Visible = false;
            }
            else
            {
                label42.Visible = true;
                textBox4.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Ідентифікаційний код";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox1.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label16.Text = "Ведите цифры!";
                    label16.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label16.Text = "";
            }

            catch
            {
                MessageBox.Show("Введите код!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox4.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label45.Text = "Ведите цифры!";
                    label45.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label45.Text = "";
            }

            catch
            {
                MessageBox.Show("Введите код филиала!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox6.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label46.Text = "Ведите цифры!";
                    label46.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label46.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите номер сведетельства!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox11.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label55.Text = "Ведите цифры!";
                    label55.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label55.Text = "";
            }

            catch
            {
                MessageBox.Show("Введите индекс!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox15.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label54.Text = "Ведите цифры!";
                    label54.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label54.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите тел. код!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox18.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label56.Text = "Ведите цифры!";
                    label56.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label56.Text = "";
            }

            catch
            {
                MessageBox.Show("Введите номер улицы!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox21.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label59.Text = "Ведите цифры!";
                    label59.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label59.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите номер дома!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox21.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label59.Text = "Ведите цифры!";
                    label59.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label59.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите номер дома!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox31.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label53.Text = "Ведите цифры!";
                    label53.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label53.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите номер счета!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox32.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label58.Text = "Ведите цифры!";
                    label58.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label58.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите код руководителя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox35.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label57.Text = "Ведите цифры!";
                    label57.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label57.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите код бухгалтера!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox38.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label63.Text = "Ведите цифры!";
                    label63.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label63.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите рабочий номер телефона руководителя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox39.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label67.Text = "Ведите цифры!";
                    label67.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label67.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите домашний номер телефона руководителя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox40.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label65.Text = "Ведите цифры!";
                    label65.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label65.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите рабочий номер телефона бухгалтера!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox41.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label67.Text = "Ведите цифры!";
                    label67.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label67.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите домашний номер телефона бухгалтера!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox22.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label60.Text = "Ведите цифры!";
                    label60.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label60.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите номер квартиры или офиса!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char t = textBox23.Text[0];
                int i = (int)t;

                if (i >= 1072 && i <= 1103)
                {
                    label61.Text = "Ведите цифры!";
                    label61.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label61.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите номер квартиры или офиса!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//                OleDbCommand cmd = new OleDbCommand();
//                cmd.Connection = con;
//                cmd.CommandText = "Create Table FizFace (ID counter primary key, [ID_Code] integer, [ShortName] varchar(100), [Latin] varchar(100), [FullName] varchar(100), [FilialCode] integer, [Date] datetime, [CertifName] integer, [Organ] varchar(40), [FormaVlasnosti] varchar(100), [OrgPravForma] varchar(100), [Country] varchar(100), [MailIndex] integer, [Oblast] varchar(100), [Distric] varchar(100), [City] varchar(100), [PhoneCode] integer, [CityDistric] varchar(100), [Street] varchar(100), [StreetType] varchar(100), [Korpus] varchar(100), [App/office] varchar(100), [E-mail] varchar(40), [WWW-adress] varchar(40), [Other] varchar(20), [Number] integer, [AccountType] varchar(40), [Valute] varchar(100), [Bank] varchar(100), [ID_Manager] integer, [FIO_Manager] varchar(100), [ManagerPosition] varchar(40), [PhoneCompManager] integer, [HomePhoneManager] integer, [ID_Accoutant] integer, [FIO_Accoutant] varchar(100), [PositionOfAccoutant] varchar(40), [CompPhonAcc] integer, [HomePhoneAcc] integer)";
//                //cmd.CommandText = "Drop Table UrFace";
//                cmd.ExecuteNonQuery();
