using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using ReadTemp;
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

namespace ServerStatus.ServerStatus
{
    public partial class FormSystemTime : Form
    {
        public FormSystemTime()
        {
            InitializeComponent();
        }

        string[] inputPass;
        string[] chooseDatabase;
        string queryString, connString, passwordString;
 

        public string Encrypt(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }

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
        }

        private void ForSystemTime_Load(object sender, EventArgs e)
        {         
            try
            {
                chooseDatabase = File.ReadAllLines("configdb.txt");
                inputPass = File.ReadAllLines("input.txt");
            }
            catch
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
            }


            listBoxSystemTime.Items.Clear();
            passwordString = Decrypt(inputPass[0], "status");
            connString = chooseDatabase[0];
            connString = connString + passwordString + ";";

            queryString = "select * from systemstatus;";
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand(queryString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBoxSystemTime.Items.Add(reader.GetDateTime("datecreated").ToString());
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
            }
        }
    }
}
