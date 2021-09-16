using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalc
{
    public partial class MiniCalc : Form
    {
        float num1, ans;
        int count;
        public MiniCalc()
        {
            
            InitializeComponent();
            num_0.Click += num_0_Click;
            num_1.Click += num_1_Click;
            num_2.Click += num_2_Click;
            add.Click += btnPlus_Click;
            divide.Click += btndivide_Click;
            clear.Click += btnC_Click;
            equals.Click += btnequal_Click;
        }
        private void num_0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 0;
        }
        private void num_1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 1;
        }
        private void num_2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 2;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(display.Text);
                display.Clear();
                display.Focus();
                count = 1;
            }
            catch {

                MessageBox.Show("Math Error");
            }

        }
        private void btndivide_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(display.Text);
                display.Clear();
                display.Focus();
                count = 2;
            }
            catch {
                MessageBox.Show("Math Error");
                display.Clear();
                count = 0;
            }
        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            display.Clear();
            count = 0;
        }
        public void compute(int count)
        {
            
            if (count == 1)
            {
                try
                {
                    ans = num1 + float.Parse(display.Text);
                    catch
                {
                    MessageBox.Show("Math error");
                    display.Clear();
                    count = 0;
                }
                display.Text = ans.ToString();

            }
            else if (count == 2)
            {
                try
                {
                    ans = num1 / float.Parse(display.Text);
                    
                   
                }
                catch
                {
                    MessageBox.Show("Math error");
                    display.Clear();
                    count = 0;
                }
                display.Text = ans.ToString();
            }
            else { 
                    
            }
        }
        
        private void MiniCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
