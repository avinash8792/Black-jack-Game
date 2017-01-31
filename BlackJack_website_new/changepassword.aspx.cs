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
    protected void Button1_Click(object sender, EventArgs e)
    {
       

        using (var context = new BlackJackOnlineEntities())
        {
            var curpswd = TextBox1.Text;
            var newpswd = TextBox2.Text;
            var conpswd = TextBox3.Text;
            var username = Session["Username"];
            if (newpswd != conpswd)
            {
                Label1.Text = "passwords did not match";
            }
            else
            {
                var res = (from r in context.Users
                           where r.UserName == username
                           select r).FirstOrDefault();
                if (res != null)
                {
                    res.Password = newpswd;
                    context.SaveChanges();

                    Response.Redirect("Home.aspx");

                }
            }
           
        }
    }
}