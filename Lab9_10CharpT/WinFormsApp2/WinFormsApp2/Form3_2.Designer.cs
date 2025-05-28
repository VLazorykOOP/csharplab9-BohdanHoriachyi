namespace WordSorter
{
    partial class Form3_2
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxInput;
        private Button buttonEvaluate;
        private Label labelResult;

        private void InitializeComponent()
        {
            this.textBoxInput = new TextBox();
            this.buttonEvaluate = new Button();
            this.labelResult = new Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(30, 30);
            this.textBoxInput.Size = new System.Drawing.Size(300, 27);
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Location = new System.Drawing.Point(30, 70);
            this.buttonEvaluate.Size = new System.Drawing.Size(150, 35);
            this.buttonEvaluate.Text = "Обчислити";
            this.buttonEvaluate.Click += new EventHandler(this.buttonEvaluate_Click);
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(30, 120);
            this.labelResult.Size = new System.Drawing.Size(300, 27);
            // 
            // Form3_2
            // 
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.labelResult);
            this.Text = "Форма 3_2 - Префіксний вираз";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
