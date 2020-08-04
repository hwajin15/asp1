using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class PostBackEx_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.PreviousPage != null)
            {
                TextBox myTextBox = (TextBox)Page.PreviousPage.FindControl("textbox1");
                Response.Write("페이지간의 게시 " + myTextBox.Text);
            }
            else
            {
                Response.Write("페이지 간 게시가 아닙니다. ");
            }
            
        }
    }
}