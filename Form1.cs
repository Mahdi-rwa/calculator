using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool plus = false;
        bool minus = false;
        bool divid = false;
        bool times = false;
        double value;
        double sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void btnpoint_Click(object sender, EventArgs e)
        {

            textBox1.Text += ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            textBox1.Clear();
            plus = true;
            textBox2.Text = $"{value} + ";
        }
        private void btnminus_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            textBox1.Clear();
            minus = true;
            textBox2.Text = $"{value} - ";
        }
        private void btntimes_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox2.Text = $"{value} * ";
            times = true;
        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            textBox1.Clear();
            divid = true;
            textBox2.Text = $"{value} / ";
        }


        private void btneq_Click(object sender, EventArgs e)
        {
            
            double num1 = value;
            double num2 = double.Parse(textBox1.Text);
            textBox1.Clear();
            if (plus)
            {
                sum = num1 + num2;
            }
            else if (minus) 
            {
                sum = num1 - num2;
            }
            else if (divid)
            {
                sum = num1 / num2;
            }
            else
            {
                sum = num1 * num2;
            }
            textBox1.Text = sum.ToString();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showAPicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
       
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void setColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            foreach (var item in Controls)
            {
                if (item is Button)
                {
                    ((Button)item).BackColor = colorDialog1.Color;
                    
                }
            }
        }

        private void setFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            foreach (var item in Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Font = fontDialog1.Font;

                }
            }
        }
        private void handToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void ppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void defulteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
