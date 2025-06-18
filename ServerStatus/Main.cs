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

        string queryString, connString, passwordString;
        int countItems;
        public static bool checkExist = false;
        public static bool localData = false;
        public static string localFilename;
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
            if (!File.Exists("input.txt"))
            {
                File.AppendAllText("input.txt", "password");
            }

            if (!File.Exists("configdb.txt"))
            {
                File.AppendAllText("configdb.txt", "SERVER=serverpc;DATABASE=serverpcstatus;UID=pcuser;PASSWORD=");
            }
            chooseDatabase = File.ReadAllLines("configdb.txt");

            inputPass = File.ReadAllLines("input.txt");
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
                    listViewShowStatus.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("cpustatus0").ToString() + " °C", reader.GetDecimal("cpustatus1").ToString() + " °C", reader.GetDecimal("cpustatus2").ToString() + " °C", reader.GetDecimal("cpustatus3").ToString() + " °C", reader.GetDecimal("cpustatus4").ToString() + " °C", reader.GetDecimal("cpustatus5").ToString() + " °C", reader.GetDecimal("hdstatus").ToString() + " °C", reader.GetDateTime("datecreated").ToString() }));
                }
                conn.Close();
                localData = false;
            }
            catch
            {
                MessageBox.Show("Check database password! Otherwise contact the administrator.");
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
            changePassword.Show();
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
            about.Show();
        }

        private void graphViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGraphView showGraph = new FormGraphView();
            showGraph.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = "";

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


                        /* firstItem = listViewShowStatus.Items[0].SubItems[3].Text;
                          lastItem = listViewShowData.Items[countItems].SubItems[3].Text;*/

                    }
                    else
                    {
                        MessageBox.Show(("This application supports only stf files"));

                    }

                }
                localFilename = openContent.FileName.ToString();
                localData = true;
            }
            catch (Exception i)
            {
                MessageBox.Show("Error message:" + i.Message);
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
    }
}
