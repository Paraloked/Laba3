using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        int h = 0;
        int b = 0;
        int[,] a;
        int i;
        int j;
        int[] mass;
        int num = 0;
        Random rands = new Random();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(textBox2.Text);
            h = Convert.ToInt32(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            a = new int[h, b];
            int i = 0;
            int j = 0;

            while (i < h){
                
                while( j< b)
                {
                    
                    a[i, j] = rands.Next(0, 10);
                    textBox1.Text += a[i, j] + " ";
                    j++;
                }
                i++;
                j = 0;
                textBox1.Text += "\r\n";
            } 
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    a[i, j] = 0;
                    textBox1.Text += a[i, j].ToString() + " ";

                }
                textBox1.Text += "\r\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int q;
            int w = 0;
            q = Convert.ToInt32(textBox4.Text);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (q == a[i, j])
                    {
                        w++;
                    }
                }

                textBox5.Text = w.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox6.Text);
            mass = new int[num];
            for (int aa = 0; aa < num; aa++)
            {
                mass[aa] = rands.Next(0, 100);
                textBox1.Text += mass[aa] + " ";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
             var vp = "C:/Users/7777d/Documents/LR3.TXT";
             File.WriteAllText(vp, textBox1.Text);

        }

    }
}
