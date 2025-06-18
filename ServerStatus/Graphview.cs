using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ServerStatus.ServerStatus
{
    public partial class FormGraphView : Form
    {
        public FormGraphView()
        {
            InitializeComponent();
        }

        string connString, passwordString, queryString;
        int addPoint = -1;
        string[] chooseDatabase;
        string[] inputPass;

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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGraphView_Load(object sender, EventArgs e)
        {
            string line, convertValue, convertValue1, convertValue2, convertValue3, convertValue4, convertValue5, convertValue6, convertValue7;
            decimal convertNewValue, convertNewValue1, convertNewValue2, convertNewValue3, convertNewValue4, convertNewValue5, convertNewValue6;
            try
            {
                chooseDatabase = File.ReadAllLines(@"configdb.txt");
                inputPass = File.ReadAllLines(@"input.txt");
                connString = chooseDatabase[0];
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error!");
                }

                if (FormMain.localData == false)
                {
                    passwordString = Decrypt(inputPass[0], "status");
                    connString = connString + passwordString + ";";
                    //     chartShowStatus.Update();
                    MessageBox.Show("Line0");
                       chartShowStatus.ChartAreas[0].AxisY.Title = "Celsius";
                    queryString = "select * from infostatus;";
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    MessageBox.Show("Line1");
                    MySqlCommand command = new MySqlCommand(queryString, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        addPoint++;
                           chartShowStatus.Series[0].Points.AddXY(addPoint, reader.GetDecimal("cpustatus0"));
                       chartShowStatus.Series[1].Points.AddXY(addPoint, reader.GetDecimal("cpustatus1"));
                          chartShowStatus.Series[2].Points.AddXY(addPoint, reader.GetDecimal("cpustatus2"));
                          chartShowStatus.Series[3].Points.AddXY(addPoint, reader.GetDecimal("cpustatus3"));
                          chartShowStatus.Series[4].Points.AddXY(addPoint, reader.GetDecimal("cpustatus4"));
                          chartShowStatus.Series[5].Points.AddXY(addPoint, reader.GetDecimal("cpustatus5"));
                          chartShowStatus.Series[6].Points.AddXY(addPoint, reader.GetDecimal("hpstatus"));
                    }
                  chartShowStatus.ChartAreas[0].AxisY.Minimum =0;
                 chartShowStatus.ChartAreas[0].AxisY.Maximum = 100;
                    conn.Close();
                    MessageBox.Show("Line2");
                }
                else
                {
                    this.Text = "Weather Station (Data from local file).";
                    StreamReader fileName3 = new StreamReader(FormMain.localFilename);
                    while ((line = fileName3.ReadLine()) != null)
                    {
                        addPoint++;
                        convertValue = line.ToString().Split(';')[0].ToString();
                        convertValue1 = line.ToString().Split(';')[1].ToString();
                        convertValue2 = line.ToString().Split(';')[2].ToString();
                        convertValue3 = line.ToString().Split(';')[3].ToString();
                        convertValue4 = line.ToString().Split(';')[4].ToString();
                        convertValue5 = line.ToString().Split(';')[5].ToString();
                        convertValue6 = line.ToString().Split(';')[6].ToString();

                        convertNewValue = decimal.Parse(convertValue);
                        convertNewValue1 = decimal.Parse(convertValue1);
                        convertNewValue2 = decimal.Parse(convertValue2);
                        convertNewValue3 = decimal.Parse(convertValue3);
                        convertNewValue4 = decimal.Parse(convertValue4);
                        convertNewValue5 = decimal.Parse(convertValue5);
                        convertNewValue6 = decimal.Parse(convertValue6);
                        convertNewValue = decimal.Parse(convertValue);

                        chartShowStatus.Series[0].Points.AddXY(addPoint, convertNewValue);
                        chartShowStatus.Series[1].Points.AddXY(addPoint, convertNewValue1);
                        chartShowStatus.Series[2].Points.AddXY(addPoint, convertNewValue2);
                        chartShowStatus.Series[3].Points.AddXY(addPoint, convertNewValue3);
                        chartShowStatus.Series[4].Points.AddXY(addPoint, convertNewValue4);
                        chartShowStatus.Series[5].Points.AddXY(addPoint, convertNewValue5);
                        chartShowStatus.Series[6].Points.AddXY(addPoint, convertNewValue6);
                    }
                    chartShowStatus.ChartAreas[0].AxisY.Minimum = 0;
                    chartShowStatus.ChartAreas[0].AxisY.Maximum = 100;
                }
            }
        }

        private void checkBoxCPUstatus0_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus0.Checked)
            {
                chartShowStatus.Series[0].IsVisibleInLegend = true;
            }
            else
            {
                chartShowStatus.Series[0].IsVisibleInLegend = false;
            }
        }

        private void checkBoxHDstatus_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxHDstatus.Checked)
            {
                chartShowStatus.Series[6].IsVisibleInLegend = true;
            }
            else
            {
                chartShowStatus.Series[6].IsVisibleInLegend = false;
            }
        }

        private void checkBoxCPUstatus1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus1.Checked)
            {
                chartShowStatus.Series[1].IsVisibleInLegend = true;
            }
            else
            {
                chartShowStatus.Series[1].IsVisibleInLegend = false;
            }
        }

        private void checkBoxCPUstatus2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus2.Checked)
            {
                chartShowStatus.Series[2].IsVisibleInLegend = true;
            }
            else
            {
                chartShowStatus.Series[2].IsVisibleInLegend = false;
            }
        }

        private void checkBoxCPUstatus3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus3.Checked)
            {
                chartShowStatus.Series[3].IsVisibleInLegend = true;
            }
            else
            {
                chartShowStatus.Series[3].IsVisibleInLegend = false;
            }
        }

        private void checkBoxCPUstatus4_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus4.Checked)
            {
                chartShowStatus.Series[4].IsVisibleInLegend = true;
            }
            else
            {
                chartShowStatus.Series[4].IsVisibleInLegend = false;
            }
        }

        private void checkBoxCPUstatus5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus5.Checked)
            {
                chartShowStatus.Series[5].IsVisibleInLegend = true;
            }
            else
            {
                chartShowStatus.Series[5].IsVisibleInLegend = false;
            }
        }
    }
}
