using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class _Default : System.Web.UI.Page
{
    public static List<int> cards;
    public static int Userscore;
    public string username;
    public static int Dealerscore ;
    public static  List<int> UserHand = new List<int>();
    public static List<int> DealerHand=new List<int>();
    public static int bet;
    public static int remfund;
    protected void Page_Load(object sender, EventArgs e)
    {
       
            
            using (var context = new BlackJackOnlineEntities())
            {
                 username = Session["Username"].ToString();
                Label1.Text = "Welcome, " + username;

                var res = (from r in context.UserFunds
                           where r.UserName == username
                           select r).FirstOrDefault();

                if (res != null)
                {
                    Label2.Text = Convert.ToString(res.Funds);
                }


            }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Userscore = 0;
        Dealerscore = 0;
        UserHand.Clear();
        DealerHand.Clear();
        Button2.Visible = true;
        Button3.Visible = true;
        Button4.Visible = true;
        Label7.Visible = true;
        Label8.Visible = true;
        bool flag = true;
        if (flag)
        {
            using (var context = new BlackJackOnlineEntities())
            {
                var betdet = (from b in context.BetRanges
                              select b).FirstOrDefault();

                int minbet = betdet.minbet;
                int maxbet = (int)betdet.maxbet;
                

                var res = (from r in context.UserFunds
                           where r.UserName == username
                           select r).FirstOrDefault();
                if (res != null)
                {
                    int betavail = Convert.ToInt32(res.Funds);
                    bet = Convert.ToInt32(TextBox1.Text);
                    if (bet >= minbet && bet <= maxbet)
                    {
                        if (bet < betavail)
                        {
                            remfund = Math.Abs(betavail - bet);
                            res.Funds = remfund;
                            context.SaveChanges();
                          //  Label3.Text = Convert.ToString(remfund);
                        }
                        else
                        {
                            Label3.Text = "Funds are not sufficient. Please add funds.";
                            Thread.Sleep(2000);
                            flag = false;
                            Response.Redirect("Addfunds.aspx");
                        }
                    }
                    else
                    {
                        
                        Label3.Text = "Bet amount is not in the range. Please enter bet amount between " + minbet + " and " + maxbet;
                        flag = false;
                    }
                }
            }
        }
        if (flag)
        {
            Label3.Visible = false;
            cards = new List<int>();
            for (int i = 1; i < 53; i++)
            {
                cards.Add(i);
            }

            string user1 = displayCard(userHand(cards));

            string user2 = displayCard(userHand(cards));
            string dealer1 = displayCard(dealerHand(cards));
            string dealer2 = displayCard(dealerHand(cards));




            User1.ImageUrl = "Images1/" + user1 + ".png";
            User2.ImageUrl = "Images1/" + user2 + ".png";
            User1.Visible = true;
            User2.Visible = true;

            Dealer1.ImageUrl = "Images1/" + dealer1 + ".png";
            Dealer2.ImageUrl = "Images1/" + dealer2 + ".png";
            Dealer1.Visible = true;
           // Dealer2.Visible = true;

            Userscore = calculateBlackJack(UserHand);
            Dealerscore = calculateBlackJack(DealerHand);

            Label4.Text = "User Score :" + Userscore;
          //  Label5.Text = "Dealer Score :" + Dealerscore;

            if (Userscore == 21)
            {
                Label6.Text = "Wow....BlackJack.. User won the game";
                remfund = ((3 * bet) + remfund);
                updateScore(remfund);
                updateGameRecord("win");
                Dealer2.Visible = true;
                Label5.Visible = true;
                Label5.Text = "Dealer Score :" + Dealerscore;


            }

        } 
    }

    public void updateScore(int score)
    {
        using (var context = new BlackJackOnlineEntities())
        {
            var res = (from r in context.UserFunds
                       where r.UserName == username
                       select r).FirstOrDefault();
            if (res != null)
            {
                res.Funds = score;
                context.SaveChanges();
            }
        }
    }

    public void updateGameRecord(string status)
    {
        using (var context = new BlackJackOnlineEntities())
        {
            var res = (from r in context.GameRecords
                       where r.UserName == username
                       select r).FirstOrDefault();
            if (res != null)
            {
                if (status == "win")
                {
                    res.Win += 1;
                }
                else if (status == "lose")
                {
                    res.Loss += 1;
                }
                else if (status == "draw")
                {
                    res.Draw += 1;
                }
                context.SaveChanges();
            }
        }
    }
    public int userHand(List<int> cards)
    {
        
        CardShuffle(cards);
        int card1 = DrawACard(cards);
        UserHand.Add(card1);
        return card1;
    }

    public int dealerHand(List<int> cards)
    {
        
        CardShuffle(cards);
        int card1 = DrawACard(cards);
        DealerHand.Add(card1);
        return card1;
    }


    public void CardShuffle(List<int> cards){
       
        Random randCard = new Random();
            int cardCount = cards.Count;
            int nxtCard = 0;
            while (cardCount > 1)
            {
                cardCount--;
                nxtCard = randCard.Next(cardCount + 1);
                int card = cards[nxtCard];
                cards[nxtCard] = cards[cardCount];
                cards[cardCount] = card;
            }
        }
    public int DrawACard(List<int> cards)
    {
        int count = cards.Count;
        int dropcard = cards[count - 1];
        cards.RemoveAt(cards.Count - 1);
        return dropcard;
    }
    

    public int getCardNumber(int num)
    {
        while (num > 13)
        {
            num = num % 13;
            if (num == 0)
            {
                num = 13;
                break;
            }
        }
        return num;
    }

    public string getCardSuit(int num)
    {
        
        if (num > 0 && num < 53)
        {
             if (num > 0 && num < 14) {
                    return "diamonds";//+"("+0+")";
                }
                else if (num > 13 && num < 27) {
                    return "clubs";//+"("+1+")";
                }
                else if (num > 26 && num < 40) {
                    return "hearts";//+"("+2+")";
                }
                else {
                    return "spades";//+"("+3+")";
                }
            }
            else {
                return "Invalid Card Number!!!";
            }

        }
    public string displayCard(int num)
    {
        int number = getCardNumber(num);
        string suit = getCardSuit(num);
        string display="";
        switch (number)
        {
            case 1:
                display = "ace";
                break;
            case 11:
                display = "jack";
                break;
            case 12:
                display = "queen";
                break;
            case 13:
                display = "king";
                break;
            default:
                display = Convert.ToString(number);
                break;
        }

        display+="_of_"+suit;
        return display;

    }

    public int calculateBlackJack(List<int> pickedcards)
    {
        int sum = 0;
        bool bj=false;
        bool bj1=false;
        for (int i = 0; i < pickedcards.Count; i++)
        {
            pickedcards[i] = getCardNumber(pickedcards[i]);
            if (pickedcards[i] > 10)
            {
                sum = sum + 10;
            }
            else if(pickedcards[i]!=1 ) 
            {
                sum = sum + pickedcards[i];
            }

            if (sum < 22 && pickedcards[i] == 1)
            {

                sum = sum + 11;
                if (sum > 21)
                {
                    sum = sum - 11;
                    sum = sum + 1;
                }
            }

            if (pickedcards[i] > 10)
            {
                bj = true;
            }
            if (pickedcards[i] == 1)
            {
                bj1 = true;
            }
            if (bj == true && bj1 == true && pickedcards.Count==2)
            {
                return 21;
            }

        }

        return sum;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if(UserHand.Count==2)
        {
        string user3 = displayCard(userHand(cards));
        User3.ImageUrl = "Images1/" + user3 + ".png";
        User3.Visible = true;
        Userscore = calculateBlackJack(UserHand);
        Label4.Text = "User Score :" + Userscore;
       // Label5.Text = "Dealer Score :" + Dealerscore;
        if (Userscore > 21)
        {
            Label6.Text = "Score is greater than 21. So User Bursted";
            updateGameRecord("lose");
            Dealer2.Visible = true;
            Label5.Visible = true;
            Label5.Text = "Dealer Score :" + Dealerscore;
        }
        }

        else  if (UserHand.Count == 3)
        {
            string user4 = displayCard(userHand(cards));
            User4.ImageUrl = "Images1/" + user4 + ".png";
            User4.Visible = true;
            Userscore = calculateBlackJack(UserHand);
            Label4.Text = "User Score :" + Userscore;
           // Label5.Text = "Dealer Score :" + Dealerscore;
            if (Userscore > 21)
            {
                Label6.Text = "Score is greater than 21. So User Bursted";
                updateGameRecord("lose");
                Dealer2.Visible = true;
                Label5.Visible = true;
                Label5.Text = "Dealer Score :" + Dealerscore;
            }
        }
        else if (UserHand.Count == 4)
        {
            string user5 = displayCard(userHand(cards));
            User5.ImageUrl = "Images1/" + user5 + ".png";
            User4.Visible = true;
            Userscore = calculateBlackJack(UserHand);
            Label4.Text = "User Score :" + Userscore;
            // Label5.Text = "Dealer Score :" + Dealerscore;
            if (Userscore > 21)
            {
                Label6.Text = "Score is greater than 21. So User Bursted";
                updateGameRecord("lose");
                Dealer2.Visible = true;
                Label5.Visible = true;
                Label5.Text = "Dealer Score :" + Dealerscore;
            }
        }
        else if (UserHand.Count == 5)
        {
            string user6 = displayCard(userHand(cards));
            User6.ImageUrl = "Images1/" + user6 + ".png";
            User6.Visible = true;
            Userscore = calculateBlackJack(UserHand);
            Label4.Text = "User Score :" + Userscore;
            // Label5.Text = "Dealer Score :" + Dealerscore;
            if (Userscore > 21)
            {
                Label6.Text = "Score is greater than 21. So User Bursted";
                updateGameRecord("lose");
                Dealer2.Visible = true;
                Label5.Visible = true;
                Label5.Text = "Dealer Score :" + Dealerscore;
            }
        }
    }
   
  
    protected void Button3_Click(object sender, EventArgs e)
    {
        Dealer2.Visible = true;
        Label5.Visible = true;
        if (Dealerscore < 17)
        {
            string delaer3 = displayCard(dealerHand(cards));
            Dealer3.ImageUrl = "Images1/" + delaer3 + ".png";
            Dealer3.Visible = true;
            Dealerscore = calculateBlackJack(DealerHand);
           // Label5.Text = "Dealer Score :" + Dealerscore;
        }
        if (Dealerscore < 17)
        {
            string delaer4 = displayCard(dealerHand(cards));
            Dealer4.ImageUrl = "Images1/" + delaer4 + ".png";
            Dealer4.Visible = true;
            Dealerscore = calculateBlackJack(DealerHand);
          //  Label5.Text = "Dealer Score :" + Dealerscore;
        }
        if (Dealerscore < 17)
        {
            string delaer5 = displayCard(dealerHand(cards));
            Dealer5.ImageUrl = "Images1/" + delaer5 + ".png";
            Dealer5.Visible = true;
            Dealerscore = calculateBlackJack(DealerHand);
           // Label5.Text = "Dealer Score :" + Dealerscore;
        }
        if (Dealerscore < 17)
        {
            string delaer6 = displayCard(dealerHand(cards));
            Dealer6.ImageUrl = "Images1/" + delaer6 + ".png";
            Dealer6.Visible = true;
            Dealerscore = calculateBlackJack(DealerHand);
            // Label5.Text = "Dealer Score :" + Dealerscore;
        }
        Label5.Text = "Dealer Score :" + Dealerscore;
        if (Dealerscore > 21)
        {
            Label6.Text = "Score is greater than 21. So Dealer Bursted";
            remfund = remfund + 2 * bet;
            updateScore(remfund);
            updateGameRecord("win");
        }
        else if (Dealerscore > Userscore)
        {
            Label6.Text = "Dealer won the deal.";
            updateGameRecord("lose");
        }
        else if (Userscore > Dealerscore)
        {
            Label6.Text = "User won the deal.";
            remfund = remfund + 2 * bet;
            updateScore(remfund);
            updateGameRecord("win");
        }
        else if (Dealerscore == Userscore)
        {
            Label6.Text = "Draw match.";
            remfund = remfund + bet;
            updateScore(remfund);
            updateGameRecord("draw");
        }
    }
   
    protected void Button4_Click1(object sender, EventArgs e)
    {
        Response.Redirect("startgame.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("startgame.aspx");
    }
}
