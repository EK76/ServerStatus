using Google.Protobuf.Collections;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
        int checkSize, checkType, checkItems = 7;
        int countCheck = 7;


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
            chartShowStatus.Series[0].XValueType = ChartValueType.DateTime;
            chartShowStatus.ChartAreas[0].AxisX.IntervalType = (DateTimeIntervalType)DateRangeType.DayOfMonth;
            chartShowStatus.ChartAreas[0].AxisX.LabelStyle.Format = "mm-hh-dd";

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

            addPoint = -1;
            foreach (var addValue in FormMain.listDate)
            {
                addPoint++;
                chartShowStatus.Series[0].Points[addPoint].AxisLabel = FormMain.listDate[addPoint];
            }
            chartShowStatus.ChartAreas[0].AxisY.Minimum = 0;
            chartShowStatus.ChartAreas[0].AxisY.Maximum = 100;


            firstItem = FormMain.listDate.First();
            lastItem = FormMain.listDate.Last();
            toolStripStatusLabel.Text = "Date intervall between " + firstItem + " and " + lastItem + ".";
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
                    //  toolStripStatusLabel.Text = string.Format("Date: {0} Temperature: {1} °C",  FormMain.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);

                    toolStripStatusLabel.Text = string.Format("Date: {0} Temperature: {1} °C", FormMain.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                    break;

                default:
                    toolStripStatusLabel.Text = "Date intervall between " + firstItem + " and " + lastItem + ".";
                    break;
            }
        }

        private void copyChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MemoryStream copypic = new MemoryStream())
            {
                chartShowStatus.SaveImage(copypic, ChartImageFormat.Jpeg);
                Bitmap newpic = new Bitmap(copypic);
                Clipboard.SetImage(newpic);
            }
        }
        private void showGaphicToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (showGaphicToolStripMenuItem.Checked == true)
            {
                chartShowStatus.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                chartShowStatus.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerSize = 8;
            }

            smallToolStripMenuItem.Checked = true;
            medumToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Enabled = true;
            checkSize = 1;
        }

        private void medumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerSize = 14;
            }

            smallToolStripMenuItem.Checked = false;
            medumToolStripMenuItem.Checked = true;
            largeToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Enabled = true;
            checkSize = 2;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerSize = 20;
            }

            smallToolStripMenuItem.Checked = false;
            medumToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = true;
            defaultToolStripMenuItem.Enabled = true;
            checkSize = 3;
        }

        private void noneMarkerSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerSize = 0;
            }

            if (noneMarkerSizeToolStripMenuItem.Checked)
            {
                markerSizeToolStripMenuItem.Enabled = true;
                markerTypeToolStripMenuItem.Enabled = true;
                noneMarkerSizeToolStripMenuItem.Checked = false;
                switch (checkSize)
                {
                    case 1:
                        for (int i = 0; i < 7; i++)
                        {
                            chartShowStatus.Series[i].MarkerSize = 8;
                        }
                        break;

                    case 2:
                        for (int i = 0; i < 7; i++)
                        {
                            chartShowStatus.Series[i].MarkerSize = 14;
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 7; i++)
                        {
                            chartShowStatus.Series[i].MarkerSize = 20;
                        }
                        break;
                }

                switch (checkType)
                {
                    case 1:
                        for (int i = 0; i < 7; i++)
                        {
                            chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Circle;
                        }
                        break;

                    case 2:
                        for (int i = 0; i < 7; i++)
                        {
                            chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Triangle;
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 7; i++)
                        {
                            chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Square;
                        }
                        break;
                    case 4:
                        for (int i = 0; i < 7; i++)
                        {
                            chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Star5;
                        }
                        break;
                }
            }
            else
            {

                markerSizeToolStripMenuItem.Enabled = false;
                markerTypeToolStripMenuItem.Enabled = false;
                noneMarkerSizeToolStripMenuItem.Checked = true;
            }
        }
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Circle;
            }

            circleToolStripMenuItem.Checked = true;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Enabled = true;
            checkType = 1;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Triangle;
            }

            circleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Enabled = true;
            checkType = 2;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Square;
            }

            circleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
            starToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Enabled = true;
            checkType = 3;
        }

        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Star5;
            }

            circleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = true;
            checkType = 4;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerSize = 14;
            }

            for (int i = 0; i < 7; i++)
            {
                chartShowStatus.Series[i].MarkerStyle = MarkerStyle.Circle;
            }

            circleToolStripMenuItem.Checked = true;
            medumToolStripMenuItem.Checked = true;
            markerTypeToolStripMenuItem.Enabled = true;
            markerSizeToolStripMenuItem.Enabled = true;
            showGaphicToolStripMenuItem.Checked = false;
            chartShowStatus.ChartAreas[0].Area3DStyle.Enable3D = false;
            noneMarkerSizeToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = false;
            smallToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Enabled = false;
        } 

        private void checkBoxCPUStatus0_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUStatus0.Checked == true)
            {
                chartShowStatus.Series[0].IsVisibleInLegend = true;
                chartShowStatus.Series[0].Enabled = true;
                countCheck++;
            }
            else
            {
                chartShowStatus.Series[0].IsVisibleInLegend = false;
                chartShowStatus.Series[0].Enabled = false;
                buttonSelectAll.Enabled = true;
                countCheck--;
            }
            if (countCheck == 0)
            {
                checkBoxCPUStatus0.Enabled = false;
                chartShowStatus.Series[0].IsVisibleInLegend = true;
                chartShowStatus.Series[0].Enabled = true;
                checkBoxCPUStatus0.Checked = true;
            }
            else
            {
                checkBoxCPUStatus0.Enabled = true;
                checkBoxCPUStatus1.Enabled = true;
                checkBoxCPUStatus2.Enabled = true;
                checkBoxCPUStatus3.Enabled = true;
                checkBoxCPUStatus4.Enabled = true;
                checkBoxCPUStatus5.Enabled = true;
                checkBoxHDStatus.Enabled = true;
            }

        }

        private void checkBoxCPUStatus1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUStatus1.Checked == true)
            {
                chartShowStatus.Series[1].IsVisibleInLegend = true;
                chartShowStatus.Series[1].Enabled = true;
                countCheck++;
            }
            else
            {
                chartShowStatus.Series[1].IsVisibleInLegend = false;
                chartShowStatus.Series[1].Enabled = false;
                buttonSelectAll.Enabled = true;
                countCheck--;
            }
            if (countCheck == 0)
            {
                checkBoxCPUStatus1.Enabled = false;
                chartShowStatus.Series[1].IsVisibleInLegend = true;
                chartShowStatus.Series[1].Enabled = true;
                checkBoxCPUStatus1.Checked = true;
            }
            else
            {
                checkBoxCPUStatus0.Enabled = true;
                checkBoxCPUStatus1.Enabled = true;
                checkBoxCPUStatus2.Enabled = true;
                checkBoxCPUStatus3.Enabled = true;
                checkBoxCPUStatus4.Enabled = true;
                checkBoxCPUStatus5.Enabled = true;
                checkBoxHDStatus.Enabled = true;
            }

        }

        private void checkBoxCPUStatus2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUStatus2.Checked == true)
            {
                chartShowStatus.Series[2].IsVisibleInLegend = true;
                chartShowStatus.Series[2].Enabled = true;
                countCheck++;
            }
            else
            {
                chartShowStatus.Series[2].IsVisibleInLegend = false;
                chartShowStatus.Series[2].Enabled = false;
                buttonSelectAll.Enabled = true;
                countCheck--;
            }
            if (countCheck == 0)
            {
                checkBoxCPUStatus2.Enabled = false;
                chartShowStatus.Series[2].IsVisibleInLegend = true;
                chartShowStatus.Series[2].Enabled = true;
                checkBoxCPUStatus2.Checked = true;
            }
            else
            {
                checkBoxCPUStatus0.Enabled = true;
                checkBoxCPUStatus1.Enabled = true;
                checkBoxCPUStatus2.Enabled = true;
                checkBoxCPUStatus3.Enabled = true;
                checkBoxCPUStatus4.Enabled = true;
                checkBoxCPUStatus5.Enabled = true;
                checkBoxHDStatus.Enabled = true;
            }

        }

        private void checkBoxCPUStatus3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUStatus3.Checked == true)
            {
                chartShowStatus.Series[3].IsVisibleInLegend = true;
                chartShowStatus.Series[3].Enabled = true;
                countCheck++;
            }
            else
            {
                chartShowStatus.Series[3].IsVisibleInLegend = false;
                chartShowStatus.Series[3].Enabled = false;
                buttonSelectAll.Enabled = true;
                countCheck--;
            }
            if (countCheck == 0)
            {
                checkBoxCPUStatus3.Enabled = false;
                chartShowStatus.Series[3].IsVisibleInLegend = true;
                chartShowStatus.Series[3].Enabled = true;
                checkBoxCPUStatus3.Checked = true;
            }
            else
            {
                checkBoxCPUStatus0.Enabled = true;
                checkBoxCPUStatus1.Enabled = true;
                checkBoxCPUStatus2.Enabled = true;
                checkBoxCPUStatus3.Enabled = true;
                checkBoxCPUStatus4.Enabled = true;
                checkBoxCPUStatus5.Enabled = true;
                checkBoxHDStatus.Enabled = true;
            }
        }

        private void checkBoxCPUStatus4_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUStatus4.Checked == true)
            {
                chartShowStatus.Series[4].IsVisibleInLegend = true;
                chartShowStatus.Series[4].Enabled = true;
                countCheck++;
            }
            else
            {
                chartShowStatus.Series[4].IsVisibleInLegend = false;
                chartShowStatus.Series[4].Enabled = false;
                buttonSelectAll.Enabled = true;
                countCheck--;
            }
            if (countCheck == 0)
            {
                checkBoxCPUStatus4.Enabled = false;
                chartShowStatus.Series[4].IsVisibleInLegend = true;
                chartShowStatus.Series[4].Enabled = true;
                checkBoxCPUStatus4.Checked = true;
            }
            else
            {
                checkBoxCPUStatus0.Enabled = true;
                checkBoxCPUStatus1.Enabled = true;
                checkBoxCPUStatus2.Enabled = true;
                checkBoxCPUStatus3.Enabled = true;
                checkBoxCPUStatus4.Enabled = true;
                checkBoxCPUStatus5.Enabled = true;
                checkBoxHDStatus.Enabled = true;
            }
        }

        private void checkBoxCPUStatus5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxCPUStatus5.Checked == true)
            {
                chartShowStatus.Series[5].IsVisibleInLegend = true;
                chartShowStatus.Series[5].Enabled = true;
                countCheck++;
            }
            else
            {
                chartShowStatus.Series[5].IsVisibleInLegend = false;
                chartShowStatus.Series[5].Enabled = false;
                buttonSelectAll.Enabled = true;
                countCheck--;
            }
            if (countCheck == 0)
            {
                checkBoxCPUStatus5.Enabled = false;
                chartShowStatus.Series[5].IsVisibleInLegend = true;
                chartShowStatus.Series[5].Enabled = true;
                checkBoxCPUStatus5.Checked = true;
            }
            else
            {
                checkBoxCPUStatus0.Enabled = true;
                checkBoxCPUStatus1.Enabled = true;
                checkBoxCPUStatus2.Enabled = true;
                checkBoxCPUStatus3.Enabled = true;
                checkBoxCPUStatus4.Enabled = true;
                checkBoxCPUStatus5.Enabled = true;
                checkBoxHDStatus.Enabled = true;
            }
        }

        private void checkBoxHDStatus_CheckStateChanged(object sender, EventArgs e)
        {      
            if (checkBoxHDStatus.Checked == true)
            {
                chartShowStatus.Series[6].IsVisibleInLegend = true;
                chartShowStatus.Series[6].Enabled = true;
                countCheck++;
            }
            else
            {
                chartShowStatus.Series[6].IsVisibleInLegend = false;
                chartShowStatus.Series[6].Enabled = false;
                buttonSelectAll.Enabled = true;
                countCheck--;
            }
            if (countCheck == 0)
            {
                checkBoxHDStatus.Enabled = false;
                chartShowStatus.Series[6].IsVisibleInLegend = true;
                chartShowStatus.Series[6].Enabled = true;
                checkBoxHDStatus.Checked = true;
            }
            else
            {
                checkBoxCPUStatus0.Enabled = true;
                checkBoxCPUStatus1.Enabled = true;
                checkBoxCPUStatus2.Enabled = true;
                checkBoxCPUStatus3.Enabled = true;
                checkBoxCPUStatus4.Enabled = true;
                checkBoxCPUStatus5.Enabled = true;
                checkBoxHDStatus.Enabled = true;
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {

            buttonSelectAll.Enabled = false;
            chartShowStatus.Series[0].IsVisibleInLegend = true;
            chartShowStatus.Series[0].Enabled = true;
            checkBoxCPUStatus0.Checked = true;
            checkBoxCPUStatus0.Enabled = true;

            chartShowStatus.Series[1].IsVisibleInLegend = true;
            chartShowStatus.Series[1].Enabled = true;
            checkBoxCPUStatus1.Checked = true;
            checkBoxCPUStatus1.Enabled = true;

            chartShowStatus.Series[2].IsVisibleInLegend = true;
            chartShowStatus.Series[2].Enabled = true;
            checkBoxCPUStatus2.Checked = true;
            checkBoxCPUStatus2.Enabled = true;

            chartShowStatus.Series[3].IsVisibleInLegend = true;
            chartShowStatus.Series[3].Enabled = true;
            checkBoxCPUStatus3.Checked = true;
            checkBoxCPUStatus3.Enabled = true;

            chartShowStatus.Series[4].IsVisibleInLegend = true;
            chartShowStatus.Series[4].Enabled = true;
            checkBoxCPUStatus4.Checked = true;
            checkBoxCPUStatus4.Enabled = true;

            chartShowStatus.Series[5].IsVisibleInLegend = true;
            chartShowStatus.Series[5].Enabled = true;
            checkBoxCPUStatus5.Checked = true;
            checkBoxCPUStatus5.Enabled = true;

            chartShowStatus.Series[6].IsVisibleInLegend = true;
            chartShowStatus.Series[6].Enabled = true;
            checkBoxHDStatus.Checked = true;
            checkBoxHDStatus.Enabled = true;
        }
    }
}
