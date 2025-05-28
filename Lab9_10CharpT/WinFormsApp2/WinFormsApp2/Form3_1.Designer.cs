namespace WordSorter
{
    partial class Form3_1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonLoad;
        private ListBox listBoxResult;

        private void InitializeComponent()
        {
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(30, 20);
            this.buttonLoad.Size = new System.Drawing.Size(200, 40);
            this.buttonLoad.Text = "Завантажити слова";
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Location = new System.Drawing.Point(30, 80);
            this.listBoxResult.Size = new System.Drawing.Size(300, 300);
            // 
            // Form3_1
            // 
            this.ClientSize = new System.Drawing.Size(380, 420);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listBoxResult);
            this.Text = "Форма 3_1 - Сортування слів";
            this.ResumeLayout(false);
        }
    }
}
