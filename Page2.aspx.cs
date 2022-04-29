using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hilo_ASP_2
{
    public partial class Page2 : System.Web.UI.Page
    {
        // ingects a message when the page is visited for the first time
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                welcome.Text = "Welcome " + ((TextBox)PreviousPage.FindControl("NameBox")).Text;
                carrier.Text = ((TextBox)PreviousPage.FindControl("NameBox")).Text;
            }
        }


        // ------------------------------------------------------------
        // Function: RangeButton_Click
        // Description: validates the inputted range, when it is valid, it tranfers to the other page.
        // Parameters:  object sender, EventArgs e
        // Returns: nothing.
        // ------------------------------------------------------------
        protected void RangeButton_Click(object sender, EventArgs e)
        {
            string inputtedMax = MaxRange.Text;
            int maxInt = 0;
            bool canConvert = int.TryParse(inputtedMax, out maxInt);
            if(canConvert == false)
            {
                MaxErr.Text = "Your max guess Shouldn't be non integer";
            }
            else
            {
                if (maxInt < 2)
                {
                    MaxErr.Text = "Your max guess Shouldn't be less than 2";
                }
                else
                {
                    Server.Transfer("Page3.aspx");
                }
            }

            
            
        }
    }
}