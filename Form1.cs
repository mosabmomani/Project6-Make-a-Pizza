using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__8__Make_a_Pizza
{

    public partial class Form1 : Form
    {
        void toppings()
        {
            string topps = " ";
            if (chbextrachees.Checked) { topps += chbextrachees.Text; }
            if (chbMushrooms.Checked) { topps += "," + chbMushrooms.Text; }
            if (chbTomatoes.Checked) { topps += "," + chbTomatoes.Text; }
            if (chbOnion.Checked) { topps += "," + chbOnion.Text; }
            if (chbOlives.Checked) { topps += "," + chbOlives.Text; }
            if (chbGreenPeppers.Checked) { topps += "," + chbGreenPeppers.Text; }
            if (topps == " ") { topps = "No Toppings"; }
            ;

            lbtoppings.Text = topps;
        }

        int topping_price()
        {
            int toppprice = 0;

            if (chbextrachees.Checked) { toppprice += Convert.ToInt32(chbextrachees.Tag); }
            if (chbMushrooms.Checked) { toppprice += Convert.ToInt32(chbMushrooms.Tag); }
            if (chbTomatoes.Checked) { toppprice += Convert.ToInt32(chbTomatoes.Tag); }
            if (chbOnion.Checked) { toppprice += Convert.ToInt32(chbOnion.Tag); }
            if (chbOlives.Checked) { toppprice += Convert.ToInt32(chbOlives.Tag); }
            if (chbGreenPeppers.Checked) { toppprice += Convert.ToInt32(chbGreenPeppers.Tag); }

            return toppprice;

        }
        int SizePrice()
        {
            int sizeprice = 0;
            if (rbSmall.Checked) { sizeprice += Convert.ToInt32(rbSmall.Tag); }

            if (rbMeduim.Checked) { sizeprice = Convert.ToInt32(rbMeduim.Tag); }

            if (rbLarge.Checked) { sizeprice += Convert.ToInt32(rbLarge.Tag); }

            return sizeprice;
        }

        int CurstPrice()
        {
            int curstprice = 0;

            if (rbThin.Checked) { curstprice += Convert.ToInt32(rbThin.Tag); }

            if (rbThick.Checked) { curstprice = Convert.ToInt32(rbThick.Tag); }

            return curstprice;
        }
        void reset()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;

            chbextrachees.Checked = false;
            chbGreenPeppers.Checked = false;
            chbMushrooms.Checked = false;
            chbOlives.Checked = false;
            chbOnion.Checked = false;
            chbTomatoes.Checked = false;

            rbMeduim.Checked = true;
            rbThin.Checked = true;
            rbEatin.Checked = true;

            numericUpDown1.Value = 1;
        }
        void TotalPrice()
        {

            int totalpriceforeach = CurstPrice() + SizePrice() + topping_price();
            int totalbill=totalpriceforeach*(int)numericUpDown1.Value;
            lbprice.Text = totalbill.ToString() + "$";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            lbsize.Text = rbSmall.Text;
        }

        private void rbmeduim_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
           
            lbsize.Text = rbMeduim.Text;
        }

        private void rblarg_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            lbsize.Text = rbLarge.Text;
        }

        private void chbextrachees_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            toppings();
        }

        private void chbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            toppings();
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            toppings();

        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            toppings();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            toppings();
        }

        private void chbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            toppings();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            lbcurst.Text = rbThin.Text;
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            if (rbThick.Checked) { lbcurst.Text = rbThick.Text; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            lbWheretoEat.Text = rbEatin.Text;
        }

        private void rbtakeout_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice();
            lbWheretoEat.Text = rbTakeOut.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed successfully","Success"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            howmanypizaa.Text=numericUpDown1.Value.ToString();
            TotalPrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TotalPrice();
        }
    }
}
