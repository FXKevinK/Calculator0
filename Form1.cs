using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator0
{
    public partial class Form1 : Form
    {
        Double val = 0;
        String num = "";
        bool Operationflag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (Operationflag))
            {
                result.Clear();
            }

            Button button = (Button)sender;
            result.Text = result.Text + button.Text;
            Operationflag = false;
        }

        private void operator_c(object sender, EventArgs e)
        {
            result.Clear();
            val = 0;
            result.Text = "0";
        }

        private void operator_ce(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_current(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (val != 0)
            {
                num = button.Text;
                curop_label.Text = val + " " + num;
                Operationflag = true;
            }
            else
            {
                num = button.Text;
                val = Double.Parse(result.Text);
                curop_label.Text = val + " " + num;
                Operationflag = true;
            }
        }

        private void label_curop(object sender, EventArgs e)
        {

        }

        private void operator_calculation(object sender, EventArgs e)
        {
            switch (num)
            {
                case "+":
                    result.Text = (val + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (val - Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (val / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (val * Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            Operationflag = false;
            val = Double.Parse(result.Text);
            curop_label.Text = "";
        }
    }
}
