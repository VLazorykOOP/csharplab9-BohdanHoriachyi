using MusicCatalog;
using PrefixEvaluator;
using System;
using System.Windows.Forms;
using WordSorter;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonOpenForm3_1_Click(object sender, EventArgs e)
        {
            Form3_1 form3_1 = new Form3_1();
            form3_1.Show();
        }

        private void buttonOpenForm3_2_Click(object sender, EventArgs e)
        {
            Form3_2 form3_2 = new Form3_2();
            form3_2.Show();
        }

        private void buttonOpenForm4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
