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

            checkValue = FormMain.hdDetails;
            checkNewValue = checkValue.TrimEnd(newChar);
            checkNewValue = checkNewValue.Split(',')[0];
            convertValue2 = Int32.Parse(checkNewValue);

            if (convertValue > 33)
            {
                labelCPUstatus.ForeColor = Color.Red;
            }

            if (convertValue2 > 33)
            {
                labelHDstatus.ForeColor = Color.Red;
            }

            labelDate.Text = "Date: " + FormMain.dateDetails;
            labelCPUstatus.Text = "CPU status: " + FormMain.cpuDetails;
            labelHDstatus.Text = "HD status: " + FormMain.hdDetails;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
