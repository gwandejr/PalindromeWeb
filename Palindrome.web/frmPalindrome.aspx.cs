using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Palindrome.web
{
    public partial class frmPalindrome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdUserInput_Click(object sender, EventArgs e)
        {
            string userPalinValue = "";
            string userPalinValueRvrs = "";

            userPalinValue = txtUserInput.Text;

            
            try
            {
                /* Checks the user input to make sure it's of an acceptable
                character length */
                if ((userPalinValue.Length >= 26) || (userPalinValue.Length < 1))
                {
                    /* Error handling for missing input or input that's too long */
                    Response.Write("Must input 1 to 25 characters.  ");
                    throw new Exception();
                }

                /* Calls the string method in the Palindrome class to reverse the user input string */
                userPalinValueRvrs = Palindrome.cs.Palindrome.GetRvrsString(userPalinValue);

                /* Calls the boolean method in the Palindrome class to compare the user input string
                with the user input string in reverse.  Based on if the strings match, a message
                is displayed to the user indicating if their input is a palindrome. */
                if (Palindrome.cs.Palindrome.IsPalindrome(userPalinValue, userPalinValueRvrs) == true)
                {
                    lblUserResult.Text = "The text entered is a palindrome.";
                }
                else
                {
                    lblUserResult.Text = "The text entered is not a palindrome.";
                }
            }
            catch (Exception ex)
            {
                Response.Write("An error has occurred.  Please start over");
            }
        }

        protected void cmdClearUserInput_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = "";
            lblUserResult.Text = "";
        }
    }
}