using MySql.Data.MySqlClient;
using ReadTemp;
using secInfo;
using Sensordevice;
using ServerStatus.ServerStatus;
using System.Data;
using System.Globalization;
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

        string queryString, passwordString, checkValue, checkNewValue, firstItem, lastItem, dayString, configPass, showUpdateDate;
        public static string dateDetails, cpuDetails, cpuDetails1, cpuDetails2, cpuDetails3, cpuDetails4, cpuDetails5, hdDetails;
        int countItems, indexNumber, countStatus, countRows;
        public static int convertValue, convertValue1, convertValue2, convertValue3, convertValue4, convertValue5, convertValue6;
        public static bool checkExist = false, checkIntervalDate = false;
        public static bool confirmed = false;
        public static string connString;
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


        void readTable(string readValue)
        {
            countItems = -1;
            countRows = 0;
            if (!File.Exists("input.txt"))
            {
                configPass = Security.encrypt("password", "status");
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
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
                FormChangePassword changePassword = new FormChangePassword();
                changePassword.ShowDialog();
            }

            listViewShowStatus.Items.Clear();
            listViewShowStatus.Update();
            passwordString = Security.decrypt(inputPass[0], "status");
            connString = chooseDatabase[0];
            connString = connString + passwordString + ";";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand(readValue, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    countItems++;
                    countRows++;
                    listViewShowStatus.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("cpustatus").ToString() + " °C", reader.GetDecimal("hdstatus").ToString() + " °C", reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm") }));
                }
                MessageBox.Show(reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm"));
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
                reloadTableToolStripMenuItem.Enabled = false;
                showServerRebootTimeToolStripMenuItem.Enabled = false;
            }

            if (countRows >= 1)
            {
                graphViewToolStripMenuItem.Enabled = true;
                markToolStripMenuItem.Enabled = true;
                showToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                setDateToolStripMenuItem.Enabled = true;
                reloadTableToolStripMenuItem.Enabled = true;
                showServerRebootTimeToolStripMenuItem.Enabled = true;
                firstItem = listViewShowStatus.Items[0].SubItems[2].Text;
                lastItem = listViewShowStatus.Items[countItems].SubItems[2].Text;
                toolStripStatusLabelRows.Text = "Date intervall between " + firstItem + " and " + lastItem + " (Data from database). Rows " + countRows.ToString();
                emptyTableToolStripMenuItem.Enabled = true;
            }
            else
            {
                graphViewToolStripMenuItem.Enabled = false;
                markToolStripMenuItem.Enabled = false;
                showToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                emptyTableToolStripMenuItem.Enabled = false;
                setDateToolStripMenuItem.Enabled = false;
                toolStripStatusLabelRows.Text = "";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            readTable("select * from infostatus ");
        }
        private void reloadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirmed = false;
            readTable("select * from infostatus ");
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
                readTable("select * from infostatus ");
            }
            checkExist = false;

        /*    if (checkIntervalDate == true)
            {
                readTable("select * from infostatus where datecreated >= '" + FormDateInterval.startDate + "' and datecreated <= '" + FormDateInterval.endDate + "' + INTERVAL 1 DAY;");
            }
            checkIntervalDate = false;*/

            if (confirmed == true)
            {
                listViewShowStatus.Clear();
                saveToolStripMenuItem.Enabled = false;
                graphViewToolStripMenuItem.Enabled = false;
                markToolStripMenuItem.Enabled = false;
                showToolStripMenuItem.Enabled = false;
                setDateToolStripMenuItem.Enabled = false;
                emptyTableToolStripMenuItem.Enabled = false;
                confirmed = false;
            }
            listViewShowStatus.Update();

        }
        private void aboutServerStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void graphViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cpuItems.Clear();
            hdItems.Clear();
            listDate.Clear();

            foreach (ListViewItem item in listViewShowStatus.Items)
            {
                cpuItems.Add(item.SubItems[0].Text);
                hdItems.Add(item.SubItems[1].Text);
                listDate.Add(item.SubItems[2].Text);
            }
            FormGraphView showGraph = new FormGraphView();
            showGraph.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = "";
            countItems = -1;
            countRows = 0;

            OpenFileDialog openContent = new OpenFileDialog();
            openContent.Title = "Server Status";
            openContent.Filter = "Status File (.stf) | *.stf";
            try
            {

                if (openContent.ShowDialog() == DialogResult.OK)
                {
                    StreamReader fileName = new StreamReader(openContent.FileName.ToString());
                    if (openContent.SafeFileName.Contains(".stf"))
                    {
                        listViewShowStatus.Items.Clear();
                        while ((line = fileName.ReadLine()) != null)
                        {
                            countItems++;
                            countRows++;
                            var itemAdd = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString(), line.ToString().Split(';')[2].ToString() });
                            listViewShowStatus.Items.Add(itemAdd);
                        }
                        fileName.Close();
                        MessageBox.Show("File " + openContent.FileName.ToString() + " is susccessfully imported!", "Server Status");
                        showToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("This application supports only stf files", "Server Status");
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
                firstItem = listViewShowStatus.Items[0].SubItems[2].Text;
                lastItem = listViewShowStatus.Items[countItems].SubItems[2].Text;
                toolStripStatusLabelRows.Text = "Date intervall " + firstItem + " between " + lastItem + " (Data from text file: " + Path.GetFileName(openContent.FileName) + ") Rows " + countRows.ToString();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveContent = new SaveFileDialog();

            saveContent.Title = "Server Status";
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
                                sw.WriteLine("{0}{1}{2}", item.SubItems[0].Text + ";", item.SubItems[1].Text + ";", item.SubItems[2].Text + ";");
                            }
                        }
                        MessageBox.Show("File " + filename + " is susccessfully saved!", "Server Status");
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
                    convertValue2 = Int32.Parse(checkNewValue);


                    if ((convertValue > 49) || (convertValue2 > 49))
                    {
                        item.SubItems[0].BackColor = Color.Red;
                        markToolStripMenuItem.Checked = true;
                        countStatus++;
                    }
                }
                if (countStatus == 0)
                {
                    MessageBox.Show("There are none critical status!" + countStatus.ToString(), "Server Status");
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
            hdDetails = listViewShowStatus.Items[indexNumber].SubItems[1].Text;
            dateDetails = listViewShowStatus.Items[indexNumber].SubItems[2].Text;
            FormDetails showDetails = new FormDetails();
            showDetails.Show();
        }

        private void listViewShowStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void emptyTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfirm confirm = new FormConfirm();
            confirm.ShowDialog();
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
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
            }
        }

        private void daytoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadTableToolStripMenuItem.Enabled = true;
            listViewShowStatus.Items.Clear();
            countRows = 0;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            queryString = "select cpustatus, datecreated, hdstatus from infostatus where datecreated like '" + daytoolStripComboBox.Text + "%'; ";

            try
            {
                MySqlCommand command = new MySqlCommand(queryString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    countItems++;
                    countRows++;
                    listViewShowStatus.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("cpustatus").ToString() + " °C", reader.GetDecimal("hdstatus").ToString() + " °C", reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm") }));
                }
                conn.Close();

                toolStripStatusLabelRows.Text = "Date: " + daytoolStripComboBox.Text + " is selected.(Data from database) Rows " + countRows.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.", "Server Status");
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

        private void showServerRebootTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSystemTime showSystemTime = new FormSystemTime();
            showSystemTime.ShowDialog();
        }

        private void setDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDateInterval showDateInterval = new FormDateInterval();
            showDateInterval.ShowDialog();
        }
    }
}
