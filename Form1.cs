using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaxsCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeginCipher();
        }

        private void DecipherBtn_Click(object sender, EventArgs e)
        {
            BeginDecipher();
        }

        void BeginCipher()
        {
            string outputPath = OutputCipherText.Text;
            string inputPath = InputCipherText.Text;

            string output;

            MainCipher.CipherText(inputPath);

            output = MainCipher.CipherdText;

            OutputCipherText.Text = output;
        }

        void BeginDecipher()
        {
            string outputPath = OutputDecipherText.Text;
            string inputPath = InputDecipherText.Text;

            string output;

            MainCipher.DecipherText(inputPath);

            output = MainCipher.DecipherdText;

            OutputDecipherText.Text = output;
        }

        private void NotWorkingBtn_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();

            helpForm.Show();
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JaxSoder/JaxsCipher");
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputCipherText.Text);
        }
    }
}
