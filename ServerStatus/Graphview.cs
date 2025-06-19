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
using System.Windows.Forms.DataVisualization.Charting;
using WinFormsApp1;

namespace ServerStatus.ServerStatus
{
    public partial class FormGraphView : Form
    {
        public FormGraphView()
        {
            InitializeComponent();
        }

        string firstItem, lastItem;
        int addPoint = -1;

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

            string addNewValue;
            decimal convertValue;

            chartShowStatus.Width = 2504;
            chartShowStatus.Update();
            //chartShowStatus.Series[0].Points.Clear();


            foreach (var addValue in FormMain.cpuItems)
            {
                addPoint++;
                char[] newChar = { '°', 'C' };
                addNewValue = addValue.TrimEnd(newChar);
                convertValue = decimal.Parse(addNewValue);
                chartShowStatus.Series[0].Points.AddXY(addPoint, convertValue);
            }

            addPoint = -1;

            foreach (var addValue in FormMain.cpuItems1)
            {
                addPoint++;
                char[] newChar = { '°', 'C' };
                addNewValue = addValue.TrimEnd(newChar);
                convertValue = decimal.Parse(addNewValue);
                chartShowStatus.Series[1].Points.AddXY(addPoint, convertValue);
            }

            addPoint = -1;
            foreach (var addValue in FormMain.cpuItems2)
            {
                addPoint++;
                char[] newChar = { '°', 'C' };
                addNewValue = addValue.TrimEnd(newChar);
                convertValue = decimal.Parse(addNewValue);
                chartShowStatus.Series[2].Points.AddXY(addPoint, convertValue);
            }

            addPoint = -1;
            foreach (var addValue in FormMain.cpuItems3)
            {
                addPoint++;
                char[] newChar = { '°', 'C' };
                addNewValue = addValue.TrimEnd(newChar);
                convertValue = decimal.Parse(addNewValue);
                chartShowStatus.Series[3].Points.AddXY(addPoint, convertValue);
            }

            addPoint = -1;
            foreach (var addValue in FormMain.cpuItems4)
            {
                addPoint++;
                char[] newChar = { '°', 'C' };
                addNewValue = addValue.TrimEnd(newChar);
                convertValue = decimal.Parse(addNewValue);
                chartShowStatus.Series[4].Points.AddXY(addPoint, convertValue);
            }

            addPoint = -1;
            foreach (var addValue in FormMain.cpuItems5)
            {
                addPoint++;
                char[] newChar = { '°', 'C' };
                addNewValue = addValue.TrimEnd(newChar);
                convertValue = decimal.Parse(addNewValue);
                chartShowStatus.Series[5].Points.AddXY(addPoint, convertValue);
            }

            addPoint = -1;
            foreach (var addValue in FormMain.hdItems)
            {
                addPoint++;
                char[] newChar = { '°', 'C' };
                addNewValue = addValue.TrimEnd(newChar);
                convertValue = decimal.Parse(addNewValue);
                chartShowStatus.Series[6].Points.AddXY(addPoint, convertValue);
            }

            chartShowStatus.ChartAreas[0].AxisY.Minimum = 0;
            chartShowStatus.ChartAreas[0].AxisY.Maximum = 100;

            firstItem = FormMain.listDate.First();
            lastItem = FormMain.listDate.Last();
            toolStripStatusLabel.Text = "Date intervall between " + firstItem + " and " + lastItem + ".";
        }

        private void checkBoxCPUstatus0_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus0.Checked)
            {
                chartShowStatus.Series[0].IsVisibleInLegend = true;
                chartShowStatus.Series[0].Enabled = true;
            }
            else
            {
                chartShowStatus.Series[0].IsVisibleInLegend = false;
                chartShowStatus.Series[0].Enabled = false;
            }
        }

        private void checkBoxHDstatus_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxHDstatus.Checked)
            {
                chartShowStatus.Series[6].IsVisibleInLegend = true;
                chartShowStatus.Series[6].Enabled = true;
            }
            else
            {
                chartShowStatus.Series[6].IsVisibleInLegend = false;
                chartShowStatus.Series[6].Enabled = false;
            }
        }

        private void checkBoxCPUstatus1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus1.Checked)
            {
                chartShowStatus.Series[1].IsVisibleInLegend = true;
                chartShowStatus.Series[1].Enabled = true;
            }
            else
            {
                chartShowStatus.Series[1].IsVisibleInLegend = false;
                chartShowStatus.Series[1].Enabled = false;
            }
        }

        private void checkBoxCPUstatus2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus2.Checked)
            {
                chartShowStatus.Series[2].IsVisibleInLegend = true;
                chartShowStatus.Series[2].Enabled = true;
            }
            else
            {
                chartShowStatus.Series[2].IsVisibleInLegend = false;
                chartShowStatus.Series[2].Enabled = false;
            }
        }

        private void checkBoxCPUstatus3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus3.Checked)
            {
                chartShowStatus.Series[3].IsVisibleInLegend = true;
                chartShowStatus.Series[3].Enabled = true;
            }
            else
            {
                chartShowStatus.Series[3].IsVisibleInLegend = false;
                chartShowStatus.Series[3].Enabled = false;
            }
        }

        private void checkBoxCPUstatus4_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus4.Checked)
            {
                chartShowStatus.Series[4].IsVisibleInLegend = true;
                chartShowStatus.Series[4].Enabled = true;
            }
            else
            {
                chartShowStatus.Series[4].IsVisibleInLegend = false;
                chartShowStatus.Series[4].Enabled = false;
            }
        }

        private void checkBoxCPUstatus5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUstatus5.Checked)
            {
                chartShowStatus.Series[5].IsVisibleInLegend = true;
                chartShowStatus.Series[5].Enabled = true;
            }
            else
            {
                chartShowStatus.Series[5].IsVisibleInLegend = false;
                chartShowStatus.Series[5].Enabled = false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsToolStripMenuItem.Checked == false)
            {
                panelStatus.Visible = true;
                chartShowStatus.Width = 2272;
                settingsToolStripMenuItem.Checked = true;
            }
            else
            {
                panelStatus.Visible = false;
                chartShowStatus.Width = 2504;
                settingsToolStripMenuItem.Checked = false;
            }
        }

        private void settingsToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chartShowStatus_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            switch (e.HitTestResult.ChartElementType)
            {

                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = string.Format("Date: {0}\n  Temperature: {1} °C", FormMain.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                    chartShowStatus.ChartAreas[0].AxisX.Title = string.Format("Date: {0} Temperature: {1} °C",  FormMain.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                    break;

                default:
                    chartShowStatus.ChartAreas[0].AxisX.Title = "Date";
                    break;
            }
        }
    }
}
