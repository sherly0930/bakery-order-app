using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakery_Products_Order_Web_Application
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page lastPage = (Page)Context.Handler;

            Label42.Text = ((TextBox)lastPage.FindControl("txtBoxName")).Text;

            //customer details
            Label2.Text = ((TextBox)lastPage.FindControl("txtBoxName")).Text;
            Label3.Text = ((TextBox)lastPage.FindControl("txtBoxPhone")).Text;
            Label4.Text = ((TextBox)lastPage.FindControl("txtBoxEmail")).Text;

            Label39.Text = ((Label)lastPage.FindControl("Label17")).Text;
            Label40.Text = ((Label)lastPage.FindControl("Label35")).Text;
            Label41.Text = ((Label)lastPage.FindControl("Label25")).Text;

            Label8.Text = ((Label)lastPage.FindControl("txtPrice1")).Text;
            Label10.Text = ((Label)lastPage.FindControl("txtPrice4")).Text;
            Label12.Text = ((Label)lastPage.FindControl("txtPrice6")).Text;

            //instructions textarea
            Label38.Text = ((TextBox)lastPage.FindControl("TextBox1")).Text;

            //total
            Label25.Text = ((Label)lastPage.FindControl("TotalLabel2")).Text;
        }
    }
}