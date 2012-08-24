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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        public OleDbConnection con = new OleDbConnection(); //коннект к базе
        public DataSet ds;                                 //Создание таблицы  
        public OleDbDataAdapter adapter;                   //запись данных в базу
        public OleDbCommand cmd = new OleDbCommand();      //событие записи в базу/файл
        public MainForm main = new MainForm();

        private void UrEdit_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Provider = Microsoft.Jet.OleDb.4.0; Data Source = data.mdb";
                con.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    string ss = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
                    string s = textBox21.Text + "/" + textBox24.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "Update UrFace Set [ERDPOU] = " + textBox1.Text + ",  [ShortName] = '" + textBox2.Text + "', [Latin] = '" + textBox3.Text + "', [FullName] = '" + textBox20.Text + "', [FilialCode] = " + textBox4.Text + ", [Date] = #" + ss + "#, [CertifNumber] = " + textBox6.Text + ", [Organ] = '" + textBox7.Text + "', [FormaVlasnosti] = '" + textBox8.Text + "', [OrgPravForma] = '" + textBox9.Text + "', "
                        + " [Country] = '" + textBox10.Text + "', [MailIndex] = " + textBox11.Text + ",  [Oblast] = '" + textBox12.Text + "', [Distric] = '" + textBox13.Text + "', [City] = '" + textBox14.Text + "', [PhoneCode] = " + textBox15.Text + ", [CityDistric] = '" + textBox17.Text + "', [Street] = " + textBox18.Text + ", [StreetType] = '" + textBox19.Text + "', [House] = " + s + ", [Korpus] = " + textBox22.Text + ", [AppOffice] = '" + textBox23.Text + "', [Email] = '" + textBox27.Text + "', "
                        + " [WWWadress] = '" + textBox26.Text + "', [Other] = '" + textBox25.Text + "', "
                        + " [Number] = " + textBox31.Text + ", [AccountType] = '" + textBox30.Text + "',  [Valute] = '" + textBox29.Text + "', [Bank]= '" + textBox28.Text + "', "
                        + " [IDManager] = " + textBox32.Text + ", [FIOManager] = '" + textBox33.Text + "', [ManagerPosition] = '" + textBox33.Text + "', [PhoneCompManager] = " + textBox38.Text + ", [HomePhoneManager] = " + textBox39.Text + ", [IDAccoutant] = " + textBox35.Text + ", [FIOAccoutant] = '" + textBox36.Text + "',"
                        + " [PositionOfAccoutant] = '" + textBox37.Text + "', [CompPhonAcc] = " + textBox40.Text + ", [HomePhoneAcc] = " + textBox41.Text + " where [ID] = " + textBox5.Text + "";

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string ss = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
                    string s = textBox21.Text + "/" + textBox24.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "Update FizFace Set [IDCode] = " + textBox1.Text + ",  [ShortName] = '" + textBox2.Text + "', [Latin] = '" + textBox3.Text + "', [FullName] = '" + textBox20.Text + "', [FilialCode] = " + textBox4.Text + ", [Date] = #" + ss + "#, [CertifNumber] = " + textBox6.Text + ", [Organ] = '" + textBox7.Text + "', [FormaVlasnosti] = '" + textBox8.Text + "', [OrgPravForma] = '" + textBox9.Text + "', "
                        + " [Country] = '" + textBox10.Text + "', [MailIndex] = " + textBox11.Text + ",  [Oblast] = '" + textBox12.Text + "', [Distric] = '" + textBox13.Text + "', [City] = '" + textBox14.Text + "', [PhoneCode] = " + textBox15.Text + ", [CityDistric] = '" + textBox17.Text + "', [Street] = " + textBox18.Text + ", [StreetType] = '" + textBox19.Text + "', [House] = " + s + ", [Korpus] = " + textBox22.Text + ", [AppOffice] = '" + textBox23.Text + "', [Email] = '" + textBox27.Text + "', "
                        + " [WWWadress] = '" + textBox26.Text + "', [Other] = '" + textBox25.Text + "', "
                        + " [Number] = " + textBox31.Text + ", [AccountType] = '" + textBox30.Text + "',  [Valute] = '" + textBox29.Text + "', [Bank]= '" + textBox28.Text + "', "
                        + " [IDManager] = " + textBox32.Text + ", [FIOManager] = '" + textBox33.Text + "', [ManagerPosition] = '" + textBox33.Text + "', [PhoneCompManager] = " + textBox38.Text + ", [HomePhoneManager] = " + textBox39.Text + ", [IDAccoutant] = " + textBox35.Text + ", [FIOAccoutant] = '" + textBox36.Text + "',"
                        + " [PositionOfAccoutant] = '" + textBox37.Text + "', [CompPhonAcc] = " + textBox40.Text + ", [HomePhoneAcc] = " + textBox41.Text + " where [ID] = " + textBox5.Text + "";

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(@"Информация сохранена в базе", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Ошибка! Возможно заполнены не все поля или введены не верные данные.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
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
                    label20.Text = "Ведите цифры!";
                    label20.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label20.Text = "";
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
                    label64.Text = "Ведите цифры!";
                    label64.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label64.Text = "";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
