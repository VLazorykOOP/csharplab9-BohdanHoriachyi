using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WordSorter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ProcessFile(ofd.FileName);
            }
        }

        private void ProcessFile(string filePath)
        {
            List<string> upperWords = new List<string>();
            List<string> lowerWords = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = Regex.Split(line, @"\s+");

                    foreach (string word in words)
                    {
                        if (string.IsNullOrWhiteSpace(word))
                            continue;

                        char firstChar = word[0];

                        if (char.IsUpper(firstChar))
                            upperWords.Add(word);
                        else if (char.IsLower(firstChar))
                            lowerWords.Add(word);
                    }
                }
            }

            txtOutput.Text = string.Join(" ", upperWords) + Environment.NewLine + string.Join(" ", lowerWords);
        }
    }
}
