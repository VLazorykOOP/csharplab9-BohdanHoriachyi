using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace WordSorter
{
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            ArrayList uppercaseWords = new ArrayList();
            ArrayList lowercaseWords = new ArrayList();

            if (!File.Exists("words.txt"))
            {
                MessageBox.Show("Файл words.txt не знайдено.");
                return;
            }

            string[] words = File.ReadAllText("words.txt").Split(new[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (char.IsUpper(word[0]))
                    uppercaseWords.Add(word);
                else
                    lowercaseWords.Add(word);
            }

            listBoxResult.Items.Clear();
            foreach (var w in uppercaseWords) listBoxResult.Items.Add(w);
            foreach (var w in lowercaseWords) listBoxResult.Items.Add(w);
        }
    }
}
