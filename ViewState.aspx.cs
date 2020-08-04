using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                System.Drawing.Color mycolor = System.Drawing.Color.FromName("red");
                TextBox1.BackColor = mycolor;
                TextBox2.BackColor = mycolor;
            }
            //처음에 실행되면 두텍스트박스 모두 빨간색이지만 btn1 이벤트 발생 이후부터는 btn2 만 빨강
            
        }
    }
}