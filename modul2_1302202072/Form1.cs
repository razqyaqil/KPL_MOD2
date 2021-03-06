using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302202072
{
    public partial class Form1 : Form
    {

        double val = 0;
        string ops = "";
        bool op_pressed = false;
        bool eq_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            val = Double.Parse(hasil.Text);
            if (val != 0 && !eq_pressed)
            {
                switch (ops)
                {
                    case "+":
                        val = (val + Double.Parse(hasil.Text));
                        break;
                }
            }
            op_pressed = true;

        }

        private void btn_click(object sender, EventArgs e)
        {

            if ((hasil.Text == "0") || (op_pressed))
            {
                op_pressed=false;   
                hasil.Clear();
            }

            Button b = (Button)sender;
            hasil.Text = hasil.Text + b.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_click(sender,e);    

        }

        private void button0_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_click(sender, e);
        }

        private void BtEqual_Click(object sender, EventArgs e)
        {
            switch (ops)
            {
                case "+":
                    hasil.Text = (val + Double.Parse(hasil.Text)).ToString();
                    op_pressed = true;
                    eq_pressed = true;
                    val = 0;    
                    break;
            }
        }

        private void BtPlus_Click(object sender, EventArgs e)
        {
            operator_click(sender, e); 
        }
    }
}
