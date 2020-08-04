using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//page 간의 게시
namespace WebApplication2
{
    public partial class PostBackEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //TextBox myTextBox = (TextBox)Page.PreviousPage.FindControl("textbox1");
                TextBox1.Text = "새로운 값을 입력하세요";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("다시게시:" + TextBox1.Text);
        }
    }
}