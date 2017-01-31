using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button1_Click1(object sender, EventArgs e)
    {
        var username = TextBox1.Text;
        var password = TextBox2.Text;
        using (var context = new BlackJackOnlineEntities())
        {
            var res = (from r in context.Users
                       where r.UserName == username && r.Password == password
                       select r).FirstOrDefault();
            if (res != null)
            {
                Session["Username"] = username;
               
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label1.Text = " Username or Password did not match. Please try again.";
            }
}
    }
}