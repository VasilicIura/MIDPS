using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
     public partial class Form1 : Form
     {

          string operand1 = string.Empty;
          string operand2 = string.Empty;
          string result;
          char operation; 

          public Form1()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               textBox1.Text += "1";
          }

        

          private void button7_Click(object sender, EventArgs e)
          {
               textBox1.Text += "7";
          }

          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void button18_Click(object sender, EventArgs e)
          {
               double putere;
               if (double.TryParse(textBox1.Text, out putere))
               {
                    textBox1.Text = (putere * putere).ToString();
               }
          }

          private void num2_Click(object sender, EventArgs e)
          {
               textBox1.Text += "2";
          }

          private void num0_Click(object sender, EventArgs e)
          {
               textBox1.Text += "0";
          }

          private void button3_Click(object sender, EventArgs e)
          {
               textBox1.Text += "3";
          }

          private void plus_Click(object sender, EventArgs e)
          {
               operand1 = textBox1.Text;
               operation = '+';
               textBox1.Text = string.Empty;
          }

          private void num4_Click(object sender, EventArgs e)
          {
               textBox1.Text += "4";
          }

          private void num5_Click(object sender, EventArgs e)
          {
               textBox1.Text += "5";
          }

          private void num6_Click(object sender, EventArgs e)
          {
               textBox1.Text += "6";
          }

          private void num8_Click(object sender, EventArgs e)
          {
               textBox1.Text += "8";
          }

          private void num9_Click(object sender, EventArgs e)
          {
               textBox1.Text += "9";
          }

          private void punct_Click(object sender, EventArgs e)
          {
               textBox1.Text += ".";
          }

          private void del_Click(object sender, EventArgs e)
          {
               textBox1.Clear();
          }

          private void plusmin_Click(object sender, EventArgs e)
          {
               double plusmin;
               plusmin = Convert.ToDouble(textBox1.Text);
               double num;
               num = plusmin - plusmin - plusmin;
               textBox1.Text = Convert.ToString(num);
          }

          private void rad_Click(object sender, EventArgs e)
          {
               double rad;
               if (double.TryParse(textBox1.Text, out rad))
               {
                    textBox1.Text = (Math.Sqrt(rad)).ToString();
               }
          }

          private void min_Click(object sender, EventArgs e)
          {
               operand1 = textBox1.Text;
               operation = '-';
               textBox1.Text = string.Empty;
          }

          private void inm_Click(object sender, EventArgs e)
          {
               operand1 = textBox1.Text;
               operation = '*';
               textBox1.Text = string.Empty;
          }

          private void imp_Click(object sender, EventArgs e)
          {
               operand1 = textBox1.Text;
               operation = '/';
               textBox1.Text = string.Empty;
          }

          private void egal_Click(object sender, EventArgs e)
          {
               operand2 = textBox1.Text;


               double opr1, opr2;
               double.TryParse(operand1, out opr1);
               double.TryParse(operand2, out opr2);
               switch (operation)
               {
                    case '+':
                         result = (opr1 + opr2).ToString();


                         break;

                    case '-':
                         result = (opr1 - opr2).ToString();
                         break;

                    case '*':
                         result = (opr1 * opr2).ToString();
                         break;

                    case '/':
                         if (opr2 != 0)
                         {
                              result = (opr1 / opr2).ToString();
                         }
                         else
                         {
                            
                         }
                         break;
               }

               textBox1.Text = result.ToString();

          }

          private void del1_Click(object sender, EventArgs e)
          {
               string num=textBox1.Text;
               if (num.Length > 1)
                    num= num.Substring(0, num.Length - 1);
               else
                    num = "";
               textBox1.Text = num;
          }
     }
}
