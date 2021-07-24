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
    public partial class EditStats : System.Web.UI.Page
    {
        PlayersDataTableAdapter playerAdap = new PlayersDataTableAdapter();
        StatisticTableAdapter statsAdap = new StatisticTableAdapter();
        PlayersTable tblPlayers = new PlayersTable();
        StatsTable tblStats = new StatsTable();

        public void searchPlayer()
        {
            string player = txtSearchPlayers.Text;
            tblPlayers = playerAdap.FindPlayer(player);
            for (int j = 0; j < tblStats.Count; j++) {
                for (int i = 0; i < tblPlayers.Count(); i++)
                 
                {
                    rdioMatchesPlayers.Items.Add(tblPlayers[i].PlayerName);
                    txtMatchesWon.Text = tblStats[j].MatchesWon.ToString();
                    txtMatchsPlayed.Text = tblStats[j].Goals.ToString();
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Grab stats and player data
            tblPlayers = playerAdap.GetPlayers();
            tblStats = statsAdap.GetStats();

      
            if (IsPostBack)
            {
                searchPlayer();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = tblPlayers[rdioMatchesPlayers.SelectedIndex].PlayerId;
            int matchesWon = int.Parse(txtMatchesWon.Text);
            int matchesPlayed = int.Parse(txtMatchsPlayed.Text);
            int assists = int.Parse(txtAssists.Text);
            int goals = int.Parse(txtGoals.Text);
            int points = (goals * 2) + assists;
           

            


            if (matchesWon <= matchesPlayed)
            {

              int result = statsAdap.UpdateStats(matchesWon, matchesPlayed, assists, goals, points, id);

            

                if (result == 1)
                {
                   lblMessage.Text = "Stats updated!";

                }
                else
                {
                   lblMessage.Text = "Failed to edit stats, check if the player you are editing has stats!";
                }
            }else
            {
                lblMessage.Text = "Make sure matches won are less than matches played!";
            }
        }
 


        protected void btnDelete_Click(object sender, EventArgs e)
        {
           int id = tblPlayers[rdioMatchesPlayers.SelectedIndex].PlayerId;
           int result = statsAdap.DeleteQuery(id);


            if (result == 1)
            {
                lblMessage.Text = "Stats Deleted!";

            }
            else
            {
                lblMessage.Text = "Failed to delete stats!";
            }

        }
    }
}