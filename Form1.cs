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
        bool plus = false , minus = false, times = false, divid;
        double value , sum , value2;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("Enter a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            sum = 0;
            value = 0;
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
        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }


        private void btnplus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                value = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox2.Text = $"{value} + ";
                plus = true;
            }
            else
            {
                MessageBox.Show("Enter a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                value = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox2.Text = $"{value} - ";
                minus = true;
            }
            else
            {
                MessageBox.Show("Enter a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btntimes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                value = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox2.Text = $"{value} × ";
                times = true;
            }
            else
            {
                MessageBox.Show("Enter a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                value = double.Parse(textBox1.Text);
                textBox1.Clear();
                divid = true;
                textBox2.Text = $"{value} ÷ ";
            }
            else
            {
                MessageBox.Show("Enter a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btneq_Click(object sender, EventArgs e)
        {
            value2 = double.Parse(textBox1.Text);
            if (plus)
            {
                sum = value + value2;
                textBox2.Text = $"{value} + {value2} = {sum}";
            }
            else if (minus)
            {
                sum = value - value2;
                textBox2.Text = $"{value} - {value2} = {sum}";
            }
            else if (times)
            {
                sum = value * value2;
                textBox2.Text = $"{value} × {value2} = {sum}";
            }
            else if (divid)
            {
                sum = value / value2;
                textBox2.Text = $"{value} ÷ {value2} = {sum}";
            }
            else
            {
                MessageBox.Show("Please select a operation" , "Error!" , MessageBoxButtons.OK ,MessageBoxIcon.Error);
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

        private void sayHiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app built for a test and a simple calculator.\n Made by Mahdi!", "About app" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void defulteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

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
