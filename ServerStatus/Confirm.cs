using MySql.Data.MySqlClient;
using secInfo;
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

namespace Sensordevice
{
    public partial class FormConfirm : Form
    {
        public FormConfirm()
        {
            InitializeComponent();
        }

        string checkString;
        private void buttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxValue.Text == "confirm")
            {
                buttonYes.Enabled = true;
            }
            else
            {
                buttonYes.Enabled = false;
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(FormMain.connString);
            conn.Open();
            checkString = "delete from infostatus";
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            conn.Close();
            FormMain.confirmed = true;
            MessageBox.Show("Table have been emptied!");
            Close();
        }
    }
}
