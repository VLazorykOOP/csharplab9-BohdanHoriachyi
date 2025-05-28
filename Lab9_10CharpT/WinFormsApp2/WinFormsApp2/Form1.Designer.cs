namespace PrefixEvaluator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Label lblResult;

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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtInput
            this.txtInput.Location = new System.Drawing.Point(30, 30);
            this.txtInput.Size = new System.Drawing.Size(300, 23);
            this.txtInput.Name = "txtInput";

            // btnEvaluate
            this.btnEvaluate.Location = new System.Drawing.Point(30, 70);
            this.btnEvaluate.Size = new System.Drawing.Size(100, 30);
            this.btnEvaluate.Text = "Обчислити";
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(30, 120);
            this.lblResult.Size = new System.Drawing.Size(300, 23);
            this.lblResult.Text = "Результат: ";

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Префіксний калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
