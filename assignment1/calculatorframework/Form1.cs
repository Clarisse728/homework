using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorframework
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalculateResult();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalculateResult()
        {
            try
            {
                // 获取第一个数字
                double num1 = double.Parse(textBox1.Text);

                // 获取第二个数字
                double num2 = double.Parse(textBox2.Text);

                // 获取运算符
                string op = textBox3.Text;

                // 计算结果
                double result = 0;
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            throw new DivideByZeroException("除数不能为零！");
                        break;
                    default:
                        throw new InvalidOperationException("无效的运算符！");
                }

                // 显示结果
                textBox4.Text = result.ToString();
            }
            catch (FormatException)
            {
                // 如果输入的不是有效数字，清空结果文本框
                textBox4.Text = "";
            }
            catch (DivideByZeroException)
            {
                // 如果除数为零，显示错误信息
                textBox4.Text = "除数不能为零！";
            }
            catch (InvalidOperationException)
            {
                // 如果运算符无效，显示错误信息
                textBox4.Text = "无效的运算符！";
            }
        }
    }
}
