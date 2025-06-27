using MySql.Data.MySqlClient;
using ReadTemp;
using ServerStatus.ServerStatus;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string queryString, connString, passwordString, checkValue, checkNewValue, firstItem, lastItem, dayString, configPass;
        public static string dateDetails, cpuDetails, cpuDetails1, cpuDetails2, cpuDetails3, cpuDetails4, cpuDetails5, hdDetails;
        int countItems, indexNumber, countStatus;
        public static int convertValue, convertValue1, convertValue2, convertValue3, convertValue4, convertValue5, convertValue6;
        public static bool checkExist = false;
        bool localData = false;
        public static List<string> cpuItems = new List<string>();
        public static List<string> cpuItems1 = new List<string>();
        public static List<string> cpuItems2 = new List<string>();
        public static List<string> cpuItems3 = new List<string>();
        public static List<string> cpuItems4 = new List<string>();
        public static List<string> cpuItems5 = new List<string>();
        public static List<string> hdItems = new List<string>();
        public static List<string> listDate = new List<string>();
        string[] chooseDatabase;
        string[] inputPass;

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

        void readTable()
        {
            countItems = -1;
            if (!File.Exists("input.txt"))
            {
                configPass = Encrypt("password", "status");
                File.AppendAllText("input.txt", configPass);
            }

            if (!File.Exists("configdb.txt"))
            {
                File.AppendAllText("configdb.txt", "SERVER=serverpc;DATABASE=serverpcstatus;UID=pcuser;PASSWORD=");
            }
            chooseDatabase = File.ReadAllLines("configdb.txt");

            try
            {
                inputPass = File.ReadAllLines("input.txt");
            }
            catch
            {
                MessageBox.Show("Check password!");
                FormChangePassword changePassword = new FormChangePassword();
                changePassword.ShowDialog();
            }

            listViewShowStatus.Items.Clear();    
            passwordString = Decrypt(inputPass[0], "status");
            connString = chooseDatabase[0];
            connString = connString + passwordString + ";";
        
            queryString = "select * from infostatus;";
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand(queryString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    countItems++;
                    listViewShowStatus.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("cpustatus0").ToString() + " °C", reader.GetDecimal("cpustatus1").ToString() + " °C", reader.GetDecimal("cpustatus2").ToString() + " °C", reader.GetDecimal("cpustatus3").ToString() + " °C", reader.GetDecimal("cpustatus4").ToString() + " °C", reader.GetDecimal("cpustatus5").ToString() + " °C", reader.GetDecimal("hdstatus").ToString() + " °C", reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm") }));
                }
                conn.Close();
                localData = false;
            }
            catch (Exception ex) 
            {
              MessageBox.Show("Check database password! Otherwise contact the administrator.");
              //  MessageBox.Show(ex.Message);
            }

            if (countItems >= 1)
            {
                graphViewToolStripMenuItem.Enabled = true;
                markToolStripMenuItem.Enabled = true;
                showToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true; ;
                firstItem = listViewShowStatus.Items[0].SubItems[7].Text;
                lastItem = listViewShowStatus.Items[countItems].SubItems[7].Text;
                toolStripStatusLabel.Text = "Date intervall between " + firstItem + " and " + lastItem + " (Data from database).";
            }
            else
            {
                graphViewToolStripMenuItem.Enabled = false;
                markToolStripMenuItem.Enabled = false;
                showToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                toolStripStatusLabel.Text = "";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            readTable();
        }
        private void reloadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readTable();
        }

        private void modifyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword changePassword = new FormChangePassword();
            changePassword.ShowDialog();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            if (checkExist == true)
            {
                readTable();
            }
            checkExist = false;
        }
        private void aboutServerStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void graphViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cpuItems.Clear();
            cpuItems1.Clear();
            cpuItems2.Clear();
            cpuItems3.Clear();
            cpuItems4.Clear();
            cpuItems5.Clear();
            hdItems.Clear();
            listDate.Clear();

            foreach (ListViewItem item in listViewShowStatus.Items)
            {
                cpuItems.Add(item.SubItems[0].Text);
                cpuItems1.Add(item.SubItems[1].Text);
                cpuItems2.Add(item.SubItems[2].Text);
                cpuItems3.Add(item.SubItems[3].Text);
                cpuItems4.Add(item.SubItems[4].Text);
                cpuItems5.Add(item.SubItems[5].Text);
                hdItems.Add(item.SubItems[6].Text);
                listDate.Add(item.SubItems[7].Text);
            }
            FormGraphView showGraph = new FormGraphView();
            showGraph.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = "";
            countItems = -1;

            OpenFileDialog openContent = new OpenFileDialog();
            openContent.Title = "Open Data";
            openContent.Filter = "Status File (.stf) | *.stf";
            try
            {
                listViewShowStatus.Items.Clear();
                if (openContent.ShowDialog() == DialogResult.OK)
                {
                    StreamReader fileName = new StreamReader(openContent.FileName.ToString());
                    if (openContent.SafeFileName.Contains(".stf"))
                    {
                        while ((line = fileName.ReadLine()) != null)
                        {
                            countItems++;
                            var itemAdd = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString(),
                            line.ToString().Split(';')[2].ToString(), line.ToString().Split(';')[3].ToString(),line.ToString().Split(';')[4].ToString(), line.ToString().Split(';')[5].ToString(), line.ToString().Split(';')[6].ToString(), line.ToString().Split(';')[7].ToString() });
                            listViewShowStatus.Items.Add(itemAdd);
                        }
                        fileName.Close();
                        MessageBox.Show("File " + openContent.FileName.ToString() + " is susccessfully imported!");
                        localData = true;
                        showToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(("This application supports only stf files"));

                    }
                }
  
            }

            catch (Exception i)
            {
                MessageBox.Show("Error message:" + i.Message);
            }

            if (countItems > 1)
            {
                graphViewToolStripMenuItem.Enabled = true;
                markToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                firstItem = listViewShowStatus.Items[0].SubItems[7].Text;
                lastItem = listViewShowStatus.Items[countItems].SubItems[7].Text;
                toolStripStatusLabel.Text = "Date intervall " + firstItem + " between " + lastItem + " (Data from text file: " + Path.GetFileName(openContent.FileName.ToString()) + ").";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveContent = new SaveFileDialog();

            saveContent.Title = "Save Data";
            saveContent.Filter = "Status File (.stf) | *.stf";

            try
            {
                if (saveContent.ShowDialog() == DialogResult.OK)
                {
                    filename = saveContent.FileName.ToString();
                    if (filename != "")
                    {
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            foreach (ListViewItem item in listViewShowStatus.Items)
                            {
                                sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", item.SubItems[0].Text + ";", item.SubItems[1].Text + ";", item.SubItems[2].Text + ";", item.SubItems[3].Text + ";", item.SubItems[4].Text + ";", item.SubItems[5].Text + ";", item.SubItems[6].Text + ";", item.SubItems[7].Text + ";");
                            }
                        }
                        MessageBox.Show("File " + filename + " is susccessfully saved!");
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (markToolStripMenuItem.Checked == false)
            {
                countStatus = 0;
                foreach (ListViewItem item in listViewShowStatus.Items)
                {
                    char[] newChar = { '°', 'C' };
                    checkValue = item.SubItems[0].Text;
                    checkNewValue = checkValue.TrimEnd(newChar);
                    checkNewValue = checkNewValue.Split(',')[0];
                    convertValue = Int32.Parse(checkNewValue);

                    checkValue = item.SubItems[1].Text;
                    checkNewValue = checkValue.TrimEnd(newChar);
                    checkNewValue = checkNewValue.Split(',')[0];
                    convertValue1 = Int32.Parse(checkNewValue);

                    checkValue = item.SubItems[2].Text;
                    checkNewValue = checkValue.TrimEnd(newChar);
                    checkNewValue = checkNewValue.Split(',')[0];
                    convertValue2 = Int32.Parse(checkNewValue);

                    checkValue = item.SubItems[3].Text;
                    checkNewValue = checkValue.TrimEnd(newChar);
                    checkNewValue = checkNewValue.Split(',')[0];
                    convertValue3 = Int32.Parse(checkNewValue);

                    checkValue = item.SubItems[4].Text;
                    checkNewValue = checkValue.TrimEnd(newChar);
                    checkNewValue = checkNewValue.Split(',')[0];
                    convertValue4 = Int32.Parse(checkNewValue);

                    checkValue = item.SubItems[5].Text;
                    checkNewValue = checkValue.TrimEnd(newChar);
                    checkNewValue = checkNewValue.Split(',')[0];
                    convertValue5 = Int32.Parse(checkNewValue);

                    checkValue = item.SubItems[6].Text;
                    checkNewValue = checkValue.TrimEnd(newChar);
                    checkNewValue = checkNewValue.Split(',')[0];
                    convertValue6 = Int32.Parse(checkNewValue);


                    if ((convertValue > 33) || (convertValue1 > 33) || (convertValue2 > 33) || (convertValue3 > 33) || (convertValue4 > 331) || (convertValue5 > 33) || (convertValue6 > 33))
                    {
                        item.SubItems[0].BackColor = Color.Red;
                        markToolStripMenuItem.Checked = true;
                        countStatus++;
                    }
                }
                if (countStatus == 0)      
                {
                    MessageBox.Show("There are not any critical status!");
                }
            }
            else
            {
                foreach (ListViewItem item in listViewShowStatus.Items)
                {
                    item.SubItems[0].BackColor = Color.White;
                }
                markToolStripMenuItem.Checked = false;
            }
        }
        private void listViewShowStatus_DoubleClick(object sender, EventArgs e)
        {
            indexNumber = listViewShowStatus.SelectedIndices[0];
            cpuDetails = listViewShowStatus.Items[indexNumber].SubItems[0].Text;
            cpuDetails1 = listViewShowStatus.Items[indexNumber].SubItems[1].Text;
            cpuDetails2 = listViewShowStatus.Items[indexNumber].SubItems[2].Text;
            cpuDetails3 = listViewShowStatus.Items[indexNumber].SubItems[3].Text;
            cpuDetails4 = listViewShowStatus.Items[indexNumber].SubItems[4].Text;
            cpuDetails5 = listViewShowStatus.Items[indexNumber].SubItems[5].Text;
            hdDetails = listViewShowStatus.Items[indexNumber].SubItems[6].Text;
            dateDetails = listViewShowStatus.Items[indexNumber].SubItems[7].Text;
            FormDetails showDetails = new FormDetails();
            showDetails.Show();
        }

        private void listViewShowStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void emptyTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult messageInfo = MessageBox.Show("Are you sure to empty the table", "Server Status", MessageBoxButtons.YesNo);
            if (messageInfo == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("delete from infostatus", conn);
                MySqlDataReader reader = command.ExecuteReader();
                conn.Close();

                conn.Open();
                MySqlCommand command2 = new MySqlCommand("alter table infostatus auto_increment=1", conn);
                MySqlDataReader reader2 = command2.ExecuteReader();
                conn.Close();
                markToolStripMenuItem.Enabled = false;
                showToolStripMenuItem.Enabled = false;
                graphViewToolStripMenuItem.Enabled = false;
                if (localData == false)
                {
                    listViewShowStatus.Items.Clear();
                    saveToolStripMenuItem.Enabled = false;
                }
                else 
                {
                    graphViewToolStripMenuItem.Enabled = true;
                    markToolStripMenuItem.Enabled = true;
                }
                toolStripStatusLabel.Text = "";
                MessageBox.Show("The table has been successfully emptied.")
            }
        }

        private void daytoolStripComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                daytoolStripComboBox.Items.Clear();
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("select date(datecreated) as 'daystatus' from infostatus group by date(datecreated) having count(*) > 1", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    daytoolStripComboBox.Items.Add(reader.GetDateTime("daystatus").ToString("yyyy-MM-dd"));
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.");
            }
        }

        private void daytoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           reloadTableToolStripMenuItem.Enabled = true;
           listViewShowStatus.Items.Clear();

           MySqlConnection conn = new MySqlConnection(connString);
           conn.Open();
           queryString = "select cpustatus0, cpustatus1, cpustatus2, cpustatus3, cpustatus4, cpustatus5, datecreated, hdstatus from infostatus where datecreated like '" + daytoolStripComboBox.Text + "%'; ";

           try
           {
                MySqlCommand command = new MySqlCommand(queryString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    countItems++;
                    listViewShowStatus.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("cpustatus0").ToString() + " °C", reader.GetDecimal("cpustatus1").ToString() + " °C", reader.GetDecimal("cpustatus2").ToString() + " °C", reader.GetDecimal("cpustatus3").ToString() + " °C", reader.GetDecimal("cpustatus4").ToString() + " °C", reader.GetDecimal("cpustatus5").ToString() + " °C", reader.GetDecimal("hdstatus").ToString() + " °C", reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm") }));
                }
                conn.Close();

                toolStripStatusLabel.Text = "Date: " + daytoolStripComboBox.Text + " is selected.";
           }
           catch (Exception ex)
           {
              MessageBox.Show("Check database password! Otherwise contact the administrator.");
           }

           if (countItems >= 1)
           {
                emptyTableToolStripMenuItem.Enabled = true;
                graphViewToolStripMenuItem.Enabled = true;
                markToolStripMenuItem.Enabled = true;
            }
            else 
            {
                graphViewToolStripMenuItem.Enabled = false;
                markToolStripMenuItem.Enabled = false;
            }
        }     
    }
}
