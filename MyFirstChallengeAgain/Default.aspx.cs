using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallengeAgain
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            decimal money = decimal.Parse(moneyTextBox.Text);
            if (money >= 50)
            {
              string result = String.Format("Well then,  {0} years old and {1:C} in your pocket, you should enjoy a night out.", age, money);
                resultLabel.Text = result;
            }

            else if ((money>= 10) && (money<50))
            {
                string result = String.Format("It's pretty good to have {1:C} in your pocket at {0} years old.", age, money);
                resultLabel.Text = result;
               }

            else

            {
                string result = String.Format("At {0} years old I would have expected you to have more than {1:C} in your pocket", age, money);
                resultLabel.Text = result;
            }
            
          
        }

    


    }
}