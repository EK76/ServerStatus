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
using WinFormsApp1;
using secInfo; 

namespace ReadTemp
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        string oldPassword, newPassword, newPassword2, connString, passwordQuery;

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            textBoxNewPassword.Text = Security.encrypt(textBoxNewPassword.Text, "status");
            File.WriteAllText(System.Environment.CurrentDirectory + "\\input.txt", textBoxNewPassword.Text);
            FormMain.checkExist = true;
            Close();

        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == true)
            {
                textBoxNewPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxNewPassword.PasswordChar = '*';
            }
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
            }
        }
    }
}
