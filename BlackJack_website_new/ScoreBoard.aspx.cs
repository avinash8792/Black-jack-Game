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
        using (var context = new BlackJackOnlineEntities())
        {
            var res = (from r in context.GameRecords
                       select r).ToList();

            Label1.Text = "The history of game players.";
                GridView1.DataSource = res;
            GridView1.DataBind();
        }
    }
}