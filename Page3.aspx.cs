using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hilo_ASP_2
{
    public partial class Page3 : System.Web.UI.Page
    {
        public string prevMaxGuess = "";
        public int rndContainer = 0;

        // ------------------------------------------------------------
        // Function: Page_Load
        // Description: ingects messages to the output and saves data to the hidden fields when visited for the first time.
        // Parameters: object sender, EventArgs e
        // Returns: nothing
        // ------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                StillWelcom.Text = ((Label)PreviousPage.FindControl("welcome")).Text + " We are still playing Hi-Lo!";
                allowable.Text = "";
                allowable.Text = "Your allowable guessing range is any value betwee 1 and " + ((TextBox)PreviousPage.FindControl("MaxRange")).Text;
                prevMaxGuess = ((TextBox)PreviousPage.FindControl("MaxRange")).Text;
                Random rnd = new Random();
                int maxInt = 0;
                bool canConvert = int.TryParse(prevMaxGuess, out maxInt);
                rndContainer = rnd.Next(1, maxInt);
                HiddenField1.Value = prevMaxGuess;
                HiddenField2.Value = rndContainer.ToString();
                carrier2.Text = ((TextBox)PreviousPage.FindControl("carrier")).Text;
            }
        }


        // ------------------------------------------------------------
        // Function: Guess_Click
        // Description: it validates the guess, and outputs error messages for the user when they input invalid data. Once it finishes validating, it transfers to page 4.
        // Parameters: object sender, EventArgs e
        // Returns: nothing
        // ------------------------------------------------------------
        protected void Guess_Click(object sender, EventArgs e)
        {

            string inputtedGuess = Guess.Text;
            int GuessInt = 0;
            bool canConvert = int.TryParse(inputtedGuess, out GuessInt);
            if (canConvert == false)
            {
                GuessErr.Text = "Shouldn't be non integer";
            }
            else
            {
                if (GuessInt < 1)
                {
                    GuessErr.Text = "Shouldn't be less than 1";
                }
                else if(GuessInt > Int32.Parse(HiddenField1.Value)) {
                    allowable.Text = "";
                    GuessErr.Text = "This number is outstide of the allowable range, wich is between 1 and " + HiddenField1.Value;
                }
                
                else if (HiddenField2.Value == GuessInt.ToString())
                {
                    Server.Transfer("Page4.aspx");
                }
                else
                {
                    allowable.Text = "Your new guessing range is between " + (GuessInt + 1).ToString() + " and "+ HiddenField1.Value;
                }
            }
        }

        
    }
}