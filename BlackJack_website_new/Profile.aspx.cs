using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var username = Session["Username"];
        Label4.Text = "Hi " + username;
        using (var context = new BlackJackOnlineEntities())
        {
            var res = (from r in context.GameRecords
                       where r.UserName == username
                       select r).FirstOrDefault();

            if (res != null)
            {
                Label1.Text = "Number of win games " + res.Win;
                Label2.Text = "Number of Loss games " + res.Loss;
                Label3.Text = "Number of Draw games " + res.Draw;
            }
                       
        }
    }
}