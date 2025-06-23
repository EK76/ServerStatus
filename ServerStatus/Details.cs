using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ServerStatus.ServerStatus
{
    public partial class FormDetails : Form
    {
        public FormDetails()
        {
            InitializeComponent();
        }
        string checkValue, checkNewValue;
        int convertValue, convertValue1, convertValue2, convertValue3, convertValue4, convertValue5, convertValue6;

        private void FormDetails_Load(object sender, EventArgs e)
        {
            char[] newChar = { '°', 'C' };
            checkValue = FormMain.cpuDetails;
            checkNewValue = checkValue.TrimEnd(newChar);
            checkNewValue = checkNewValue.Split(',')[0];
            convertValue = Int32.Parse(checkNewValue);

            checkValue = FormMain.cpuDetails1;
            checkNewValue = checkValue.TrimEnd(newChar);
            checkNewValue = checkNewValue.Split(',')[0];
            convertValue1 = Int32.Parse(checkNewValue);

            checkValue = FormMain.cpuDetails2;
            checkNewValue = checkValue.TrimEnd(newChar);
            checkNewValue = checkNewValue.Split(',')[0];
            convertValue2 = Int32.Parse(checkNewValue);

            checkValue = FormMain.cpuDetails3;
            checkNewValue = checkValue.TrimEnd(newChar);
            checkNewValue = checkNewValue.Split(',')[0];
            convertValue3 = Int32.Parse(checkNewValue);

            checkValue = FormMain.cpuDetails4;
            checkNewValue = checkValue.TrimEnd(newChar);
            checkNewValue = checkNewValue.Split(',')[0];
            convertValue4 = Int32.Parse(checkNewValue);

            checkValue = FormMain.cpuDetails5;
            checkNewValue = checkValue.TrimEnd(newChar);
            checkNewValue = checkNewValue.Split(',')[0];
            convertValue5 = Int32.Parse(checkNewValue);

            checkValue = FormMain.hdDetails;
            checkNewValue = checkValue.TrimEnd(newChar);
            checkNewValue = checkNewValue.Split(',')[0];
            convertValue6 = Int32.Parse(checkNewValue);

            if (convertValue > 33)
            {
                labelCPUstatus.ForeColor = Color.Red;
            }

            if (convertValue1 > 33)
            {
                labelCPUstatus1.ForeColor = Color.Red;
            }

            if (convertValue2 > 33)
            {
                labelCPUstatus2.ForeColor = Color.Red;
            }

            if (convertValue3 > 33)
            {
                labelCPUstatus3.ForeColor = Color.Red;
            }

            if (convertValue4 > 33)
            {
                labelCPUstatus4.ForeColor = Color.Red;
            }

            if (convertValue5 > 33)
            {
                labelCPUstatus5.ForeColor = Color.Red;
            }

            if (convertValue6 > 33)
            {
                labelHDstatus.ForeColor = Color.Red;
            }

            labelDate.Text = "Date: " + FormMain.dateDetails;
            labelCPUstatus.Text = "CPU status 0: " + FormMain.cpuDetails;
            labelCPUstatus1.Text = "CPU status 1: " + FormMain.cpuDetails1;
            labelCPUstatus2.Text = "CPU status 2: " + FormMain.cpuDetails2;
            labelCPUstatus3.Text = "CPU status 3: " + FormMain.cpuDetails3;
            labelCPUstatus4.Text = "CPU status 4: " + FormMain.cpuDetails4;
            labelCPUstatus5.Text = "CPU status 5: " + FormMain.cpuDetails5;
            labelHDstatus.Text = "HD status: " + FormMain.hdDetails;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
