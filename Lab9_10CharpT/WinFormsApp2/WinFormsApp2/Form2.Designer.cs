namespace WordSorter
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // btnOpenFile
            this.btnOpenFile.Location = new System.Drawing.Point(20, 20);
            this.btnOpenFile.Size = new System.Drawing.Size(100, 30);
            this.btnOpenFile.Text = "Відкрити файл";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);

            // txtOutput
            this.txtOutput.Location = new System.Drawing.Point(20, 70);
            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(460, 250);

            // Form2
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form2";
            this.Text = "Розділення слів за регістром";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
