using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakery_Products_Order_Web_Application
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            double price1 = Convert.ToDouble(CheckBox1.Checked);
            double price2 = Convert.ToDouble(CheckBox2.Checked);
            double price3 = Convert.ToDouble(CheckBox3.Checked);
            double price4 = Convert.ToDouble(CheckBox4.Checked);
            double price5 = Convert.ToDouble(CheckBox5.Checked);
            double price6 = Convert.ToDouble(CheckBox6.Checked);
            double price7 = Convert.ToDouble(CheckBox7.Checked);
            double price8 = Convert.ToDouble(CheckBox8.Checked);
            double price9 = Convert.ToDouble(CheckBox9.Checked);
            double price10 = Convert.ToDouble(CheckBox10.Checked);

            double Total;
            Total = 0;
           

            if (CheckBox1.Checked == true)
            {
                price1 = 2.80;
            }

            if (CheckBox2.Checked == true)
            {
                price2 = 3.50;
            }

            if (CheckBox3.Checked == true)
            {
                price3 = 2.30;
            }

            if (CheckBox4.Checked == true)
            {
                price4 = 6.90;
            }

            if (CheckBox5.Checked == true)
            {
                price5 = 7.35;
            }

            if (CheckBox6.Checked == true)
            {
                price6 = 2.20;
            }

            if (CheckBox7.Checked == true)
            {
                price7 = 9.20;
            }

            if (CheckBox8.Checked == true)
            {
                price8 = 5.69;
            }

            if (CheckBox9.Checked == true)
            {
                price9 = 10.10;
            }

            if (CheckBox10.Checked == true)
            {
                price10 = 2.05;
            }

            Total = price1 + price2 + price3 + price4 + price5 + price6 + price7 + price8 + price9 + price10;

            TotalLabel2.Text = Total.ToString();

        }


            protected void Croissant_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CalculateBtn_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Server.Transfer("Feedback.aspx");

            Label3.Text = "Special Instructions";
            Label3.Text = TextBox1.Text;

            lblName.Text = "Name";
            lblName.Text = txtBoxName.Text;

            lblPhone.Text = "Phone number";
            lblPhone.Text = txtBoxPhone.Text;

            lblEmail.Text = "Email";
            lblEmail.Text = txtBoxEmail.Text;
        }
    }
}