using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrefixEvaluator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text.Trim();
                string[] tokens = input.Split(' ');
                Stack<string> stack = new Stack<string>(tokens.Reverse());
                double result = EvaluatePrefix(stack);
                lblResult.Text = "Результат: " + result;
            }
            catch (Exception ex)
            {
                lblResult.Text = "Помилка: " + ex.Message;
            }
        }

        private double EvaluatePrefix(Stack<string> stack)
        {
            if (stack.Count == 0)
                throw new Exception("Недійсний вираз");

            string token = stack.Pop();

            if (IsOperator(token))
            {
                double operand1 = EvaluatePrefix(stack);
                double operand2 = EvaluatePrefix(stack);
                return ApplyOperator(token, operand1, operand2);
            }
            else
            {
                return double.Parse(token);
            }
        }

        private bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        private double ApplyOperator(string op, double a, double b)
        {
            return op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => b != 0 ? a / b : throw new DivideByZeroException(),
                _ => throw new Exception("Невідомий оператор: " + op)
            };
        }
    }
}
