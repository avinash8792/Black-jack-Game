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
        
        string username = Session["Username"].ToString();
        
        
        if (username != "dealer")
        {
            Label3.Text = "Sorry You are not authorized to use this page.";
        }
        else if(username == "dealer")
        {
            minLabel.Visible = true;
            maxLabel.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;  
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int minbet = Convert.ToInt32(TextBox1.Text);
        int maxbet = Convert.ToInt32(TextBox2.Text);

        using (var context = new BlackJackOnlineEntities())
        {
            var res = (from r in context.BetRanges
                       select r).FirstOrDefault();
            if (res != null)
            {
                res.minbet = minbet;
                res.maxbet = maxbet;
                context.SaveChanges();
            }
            else if (res == null)
            {
                var betdetails = new BetRange();
                betdetails.minbet = minbet;
                betdetails.maxbet = maxbet;
                context.BetRanges.Add(betdetails);
                context.SaveChanges();
            }
        }
    }
}