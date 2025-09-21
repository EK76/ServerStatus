using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ServerStatus.ServerStatus
{
    public partial class FormDateInterval : Form
    {
        public FormDateInterval()
        {
            InitializeComponent();
        }

        string[] inputPass;
        string[] chooseDatabase;
        string queryString, connString, passwordString;
        public static string startDate, endDate;
        public static string Decrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] byteBuff = Convert.FromBase64String(encrypt);
                    return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
            FormMain.checkIntervalDate = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDateInterval_Load(object sender, EventArgs e)
        {
            comboBoxStartDate.Items.Clear();
            comboBoxEndDate.Items.Clear();
            comboBoxEndDate.Enabled = false;
            try
            {
                chooseDatabase = File.ReadAllLines("configdb.txt");
                inputPass = File.ReadAllLines("input.txt");
            }
            catch
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
            }
            try
            {
                passwordString = Decrypt(inputPass[0], "status");
                connString = chooseDatabase[0];
                connString = connString + passwordString + ";";

                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("select date(datecreated) as 'daystatus' from infostatus group by date(datecreated) having count(*) > 1", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxStartDate.Items.Add(reader.GetDateTime("daystatus").ToString("yyyy-MM-dd"));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
            }
        }

        private void comboBoxEndDate_Click(object sender, EventArgs e)
        {
            comboBoxEndDate.Items.Clear();
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("select date(datecreated) as 'daystatus' from infostatus group by date(datecreated) having daystatus > '" + startDate + "'", conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxEndDate.Items.Add(reader.GetDateTime("daystatus").ToString("yyyy-MM-dd"));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
            }
        }

        private void comboBoxStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            startDate = comboBoxStartDate.Text;
            comboBoxEndDate.Enabled = true;
        }

        private void comboBoxEndDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            endDate = comboBoxEndDate.Text;
        }
    }
}

