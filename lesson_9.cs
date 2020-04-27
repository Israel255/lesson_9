using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_numbers
{
    public partial class random_num_form : Form
    {
        public random_num_form()
        {
            InitializeComponent();
        }

        private void lottery_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int minimum = Convert.ToInt32(min_num.Text);
                int maximum = Convert.ToInt32(max_num.Text);
                Random num = new Random();
                int number = num.Next(minimum, maximum + 1);
                random_num_lbl.Text = "the number is: " + number;
                Debug.WriteLine("the number is: " + number);
                Debug.WriteLine("the min num is: " + minimum);
                Debug.WriteLine("the max num is: " + maximum);
            }
            catch
            {
                random_num_lbl.Text = "wrong input";
            }
        }

        private void zerofy_Click(object sender, EventArgs e)
        {
            min_num.Text = "0";
            max_num.Text = "0";
        }
    }
}
