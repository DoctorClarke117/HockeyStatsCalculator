using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HockeyNicholasNieto.PlayerTableAdapters;
namespace HockeyNicholasNieto
{
    using PlayersTable = Player.PlayersDataDataTable;
    using StatsTable = Player.StatisticDataTable;
    public partial class AddStats : System.Web.UI.Page
    {

        PlayersDataTableAdapter playerAdap = new PlayersDataTableAdapter();
        StatisticTableAdapter statsAdap = new StatisticTableAdapter();
        PlayersTable tblPlayers = new PlayersTable();
        StatsTable tblStats = new StatsTable();


        public void searchPlayer()
        {
          
            for (int i = 0; i < tblPlayers.Count(); i++)
            {
                displayPlayer.Items.Add(tblPlayers[i].PlayerName);
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Grab stats and player data
            tblPlayers = playerAdap.GetPlayers();
            tblStats = statsAdap.GetStats();

            if (!IsPostBack)
            {
                searchPlayer();
            }
        }

        protected void btnAddStats_Click(object sender, EventArgs e)
        {
            int matchesWon = int.Parse(txtMatchesWon.Text);
            int matchesPlayed = int.Parse(txtMatchsPlayed.Text);
            int assists = int.Parse(txtAssists.Text);
            int goals = int.Parse(txtGoals.Text);
            string player = displayPlayer.Text;
            int points = (goals * 2) + assists;



            int id = tblPlayers[displayPlayer.SelectedIndex].PlayerId;


            if (matchesWon <= matchesPlayed)
            {
                int result = statsAdap.InsertStats(matchesPlayed, assists, goals, matchesWon, id, points);

                if (result == 1)
                {
                    lblMessage.Text = "Player Stats Added!";

                }
                else
                {
                    lblMessage.Text = "Player stats was not Added";
                }
            }
            else
            {
                lblMessage.Text = "Matches won canno't be less than matches played!";
            }
               

        }
               
    }
}