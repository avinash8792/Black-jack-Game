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
        var username = Session["Username"];
        var newfund = Convert.ToInt32(TextBox1.Text);

        using (var context = new BlackJackOnlineEntities())
        {
            var res = (from r in context.UserFunds
                       where r.UserName == username
                       select r).FirstOrDefault();

            if (res!= null)
            {
                res.Funds += newfund;
                context.SaveChanges();
                Response.Redirect("Home.aspx");
            }

        }
    }
}