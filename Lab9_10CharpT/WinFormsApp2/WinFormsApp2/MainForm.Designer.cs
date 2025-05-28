namespace WinFormsApp2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenForm1;
        private System.Windows.Forms.Button buttonOpenForm2;
        private System.Windows.Forms.Button buttonOpenForm3_1;
        private System.Windows.Forms.Button buttonOpenForm3_2;
        private System.Windows.Forms.Button buttonOpenForm4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonOpenForm1 = new Button();
            buttonOpenForm2 = new Button();
            buttonOpenForm3_1 = new Button();
            buttonOpenForm3_2 = new Button();
            buttonOpenForm4 = new Button();

            SuspendLayout();

            buttonOpenForm1.Location = new Point(44, 22);
            buttonOpenForm1.Margin = new Padding(3, 2, 3, 2);
            buttonOpenForm1.Name = "buttonOpenForm1";
            buttonOpenForm1.Size = new Size(131, 30);
            buttonOpenForm1.TabIndex = 0;
            buttonOpenForm1.Text = "Відкрити Форму 1";
            buttonOpenForm1.UseVisualStyleBackColor = true;
            buttonOpenForm1.Click += buttonOpenForm1_Click;

            buttonOpenForm2.Location = new Point(44, 68);
            buttonOpenForm2.Margin = new Padding(3, 2, 3, 2);
            buttonOpenForm2.Name = "buttonOpenForm2";
            buttonOpenForm2.Size = new Size(131, 30);
            buttonOpenForm2.TabIndex = 1;
            buttonOpenForm2.Text = "Відкрити Форму 2";
            buttonOpenForm2.UseVisualStyleBackColor = true;
            buttonOpenForm2.Click += buttonOpenForm2_Click;

            buttonOpenForm3_1.Location = new Point(44, 114);
            buttonOpenForm3_1.Margin = new Padding(3, 2, 3, 2);
            buttonOpenForm3_1.Name = "buttonOpenForm3_1";
            buttonOpenForm3_1.Size = new Size(131, 30);
            buttonOpenForm3_1.TabIndex = 2;
            buttonOpenForm3_1.Text = "Відкрити Форму 3_1";
            buttonOpenForm3_1.UseVisualStyleBackColor = true;
            buttonOpenForm3_1.Click += buttonOpenForm3_1_Click;

            buttonOpenForm3_2.Location = new Point(44, 160);
            buttonOpenForm3_2.Margin = new Padding(3, 2, 3, 2);
            buttonOpenForm3_2.Name = "buttonOpenForm3_2";
            buttonOpenForm3_2.Size = new Size(131, 30);
            buttonOpenForm3_2.TabIndex = 3;
            buttonOpenForm3_2.Text = "Відкрити Форму 3_2";
            buttonOpenForm3_2.UseVisualStyleBackColor = true;
            buttonOpenForm3_2.Click += buttonOpenForm3_2_Click;

            buttonOpenForm4.Location = new Point(44, 206);
            buttonOpenForm4.Margin = new Padding(3, 2, 3, 2);
            buttonOpenForm4.Name = "buttonOpenForm4";
            buttonOpenForm4.Size = new Size(131, 30);
            buttonOpenForm4.TabIndex = 4;
            buttonOpenForm4.Text = "Відкрити Форму 4";
            buttonOpenForm4.UseVisualStyleBackColor = true;
            buttonOpenForm4.Click += buttonOpenForm4_Click;

            ClientSize = new Size(219, 255);
            Controls.Add(buttonOpenForm4);
            Controls.Add(buttonOpenForm3_2);
            Controls.Add(buttonOpenForm3_1);
            Controls.Add(buttonOpenForm2);
            Controls.Add(buttonOpenForm1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Головне меню";
            Load += MainForm_Load;

            ResumeLayout(false);
        }
    }
}
