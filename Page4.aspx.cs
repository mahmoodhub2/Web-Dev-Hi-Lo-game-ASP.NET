using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hilo_ASP_2
{
    public partial class Page4 : System.Web.UI.Page
    {
        // outputs a winning message if the user wins, and saves thier name in a hidden textbox
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                wonL.Text = "You Win!! You guessed the number!!";
                NameBox.Text = ((TextBox)PreviousPage.FindControl("carrier2")).Text;

            }
        }


        // ------------------------------------------------------------
        // Function: Button1_Click
        // Description: transfers the user to page 2, wich is the max guess page.
        // Parameters:  object sender, EventArgs e
        // Returns: none.
        // ------------------------------------------------------------
        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Page2.aspx");
        }
    }
}