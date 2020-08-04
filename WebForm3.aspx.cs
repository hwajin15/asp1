using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
  

    public partial class WebForm3 : System.Web.UI.Page
    {
        public string a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1 and TextBox2 Value is Assigning on the variable a and b  
            a = TextBox1.Text;
            b = TextBox2.Text;
            //after clicking on Button TextBox value Will be Cleared  
            TextBox1.Text = TextBox2.Text = string.Empty;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //value of variable a and b is assingning on TextBox1 and Textbox2  
            TextBox1.Text = a;
            TextBox2.Text = b;
        }
    }
}