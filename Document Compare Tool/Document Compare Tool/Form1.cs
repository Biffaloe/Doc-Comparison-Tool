using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace Document_Compare_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblProcessing.Text = string.Empty;
        }

        string File1Content = string.Empty;
        string File2Content = string.Empty;
        string newLine = Environment.NewLine;

        private void btnCompare_Click(object sender, EventArgs e)
        {
            txtboxResults.Text = string.Empty;
            lblProcessing.Text = "Processing...\nThe program may seem unresponsive but\ndon't worry. Thats merely the result of Kevin\nnot wanting to deal with\nasynchronous programming.\nProcessing...";

            string[] fileOne = File1Content.Split('!', '.', '?');
            string[] fileTwo = File2Content.Split('!', '.', '?');

            int count = 0;
            foreach(string x in fileOne)
            {
                if (x != null && fileTwo[count] != null)
                {
                    if (x != fileTwo[count])
                    {
                        txtboxResults.Text += $"Difference detected in sentence {count + 1}." + newLine + newLine;
                        txtboxResults.Text += lblDoc1.Text + ":" + newLine + x + newLine + lblDoc2.Text + ":" + newLine + fileTwo[count] + newLine;
                    }
                }
                else
                {
                    txtboxResults.Text += lblDoc2.Text + "has fewer sentences than" + lblDoc1.Text + newLine;
                    break;
                }
                count++;
            }

            lblProcessing.Text = string.Empty;
        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            File1Content = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    lblDoc1.Text = Path.GetFileName(filePath);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        File1Content = reader.ReadToEnd();
                    }
                }
            }
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            File2Content = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    lblDoc2.Text = Path.GetFileName(filePath);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        File2Content = reader.ReadToEnd();
                    }
                }
            }
        }
    }
}