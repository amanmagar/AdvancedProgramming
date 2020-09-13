using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        int  quantity,index = 0;
        double rate,total,totalamount= 0;
        public void Clearscreen()
        {
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtRate.Text = "";
        }
        public 
         void Discount(double num, double discountinpercent)
        {
            lblDiscount.Text = discountinpercent.ToString();
            double discount = ((discountinpercent / 100) * num);
            double discountedamount = (num - discount);
            lblFinalTotal.Text = discountedamount.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtQuantity.Text == "" || txtRate.Text == "")
            {
                MessageBox.Show(" Please provide all the details");
            }
            else
            {
                index++;
                string pname = txtProductName.Text;
                quantity = int.Parse(txtQuantity.Text);
                rate = double.Parse(txtRate.Text);
                total = quantity * rate;
                totalamount += total;
                if (totalamount > 0 && totalamount < 1000)
                {
                    double discountinpercent = 2;
                    Discount(totalamount, discountinpercent);
                }
                else if (totalamount >= 1000 && totalamount < 10000)
                {
                    double discountinpercent = 5;
                    Discount(totalamount, discountinpercent);
                }
                else if (totalamount >= 10000 && totalamount < 200008)
                {
                    double discountinpercent = 8;
                    Discount(totalamount, discountinpercent);
                }
                else if (totalamount >= 200008 && totalamount < 50000)
                {
                    double discountinpercent = 10;
                    Discount(totalamount, discountinpercent);
                }
                else if (totalamount >= 50000)
                {
                    double discountinpercent = 15;
                    Discount(totalamount, discountinpercent);
                }
                lbltotal.Text = total.ToString();
                lblItemsCount.Text = index.ToString();
                dgBilling.Rows.Add(index, pname, quantity, rate, total);
                Clearscreen();
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {
           
        }
    }
}
