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
        var repswd = TextBox3.Text;

        if (password != repswd)
        {
            Label1.Text = "password and retype password did not match";
        }
        else
        {
            
            using (var context = new BlackJackOnlineEntities())
            {
                var res = (from r in context.Users
                           where r.UserName == username && r.Password == password
                           select r).FirstOrDefault();
               
                
                if (res != null)
                {
                    Label1.Text = "Account already exist.";
                }
                else{
                    

                    var userprofile = new User();
                      userprofile.UserName = username;
                      userprofile.Password = password;

                      var gamerec = new GameRecord();
                      gamerec.UserName = username;
                      gamerec.Win = 0;
                      gamerec.Loss = 0;
                      gamerec.Draw = 0;

                      var initfund = new UserFund();
                      initfund.Funds = 300;
                      initfund.UserName = username;
                    
                    context.Users.Add(userprofile);
                    context.GameRecords.Add(gamerec);
                    context.UserFunds.Add(initfund);      
                    context.SaveChanges();

                    Response.Redirect("Login.aspx");

                }
            }

            
            
        }
    }
}