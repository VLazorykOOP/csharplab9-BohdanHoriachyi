using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordSorter
{
    public partial class Form3_2 : Form
    {
        public Form3_2()
        {
            InitializeComponent();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                string expr = textBoxInput.Text;
                string[] tokens = expr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Stack<string> stack = new Stack<string>(tokens);
                double result = EvaluatePrefix(stack);
                labelResult.Text = $"Результат: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка у виразі: " + ex.Message);
            }
        }

        private double EvaluatePrefix(Stack<string> stack)
        {
            string token = stack.Pop();

            if (double.TryParse(token, out double num))
                return num;

            double op1 = EvaluatePrefix(stack);
            double op2 = EvaluatePrefix(stack);

            return token switch
            {
                "+" => op1 + op2,
                "-" => op1 - op2,
                "*" => op1 * op2,
                "/" => op1 / op2,
                _ => throw new Exception("Невідомий оператор"),
            };
        }
    }
}
