using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMQSTYLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N, test;
            int max = 0;
            int min = 15;
            decimal ave;
            int total = 0;
            Random rand = new Random();
            if(int.TryParse(textBox1.Text, out N))
            {
                for(int i = 1; i <= N; i++)
                {
                    test=rand.Next(1,16);
                    listBox1.Items.Add(test);
                    if(test>max)
                    {
                        max= test;
                    }
                    if(test<min) 
                    { 
                    min= test;
                    }
                    total += test;
                }
                ave = (decimal)total / listBox1.Items.Count;
                textBox2.Text = max.ToString();
                textBox3.Text = min.ToString();
                textBox4.Text = ave.ToString();
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int selecteditem= Convert.ToInt32(listBox1.SelectedItem);
            int selectedindex=listBox1.SelectedIndex;
            int number= random.Next(1,15);
            while(selecteditem==number)
            {
                number=random.Next(1,15);
            }
            listBox1.Items[selectedindex] = number;
        }
    }
}
