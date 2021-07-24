using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HockeyNicholasNieto.PlayerTableAdapters;
namespace HockeyNicholasNieto

{


    using StatsTable = Player.StatisticDataTable;
    using PlayersTable = Player.PlayersDataDataTable;

    public partial class HomePage : System.Web.UI.Page
    {

        PlayersDataTableAdapter playerAdap = new PlayersDataTableAdapter();
        PlayersTable tblPlayers = new PlayersTable();
        StatsTable tblStats = new StatsTable();
        StatisticTableAdapter statsAdap = new StatisticTableAdapter();


        protected void Page_Load(object sender, EventArgs e)
        {

            // Grab stats and player data
            tblPlayers = playerAdap.GetPlayers();
            tblStats = statsAdap.GetStats();
            int highestPoints = tblStats[0].Points;
        

            if (!IsPostBack)
            {
                if (tblStats.Count == 1)
                {
                    lblHighestPoints.Text = "Highest Points: " + tblStats[0].Points.ToString();
                }
                else
                {

                    // loop to search players
                    for(int j = 0; j < tblPlayers.Count(); j++) {

                        // loop to search player stats
                        for (int i = 0; i < tblStats.Count(); i++)
                        {

                            if (tblStats[i].Points >= highestPoints)
                            {
                                lblHighestPoints.Text = "Highest Points: " + tblStats[i].Points.ToString();

                                if (tblPlayers[j].PlayerId == tblStats[i].PlayerId)
                                {
                                    lblPlayer1.Text = "Player: " + tblPlayers[j].PlayerName;
                                }
                              
                            }

                            if (tblStats[i].Points <= highestPoints)
                            {
                                lblLowestPoints.Text = "Lowest Points: " + tblStats[i].Points.ToString();

                                if (tblPlayers[j].PlayerId == tblStats[i].PlayerId)
                                {
                                    lblPlayer.Text = "Player: " + tblPlayers[j].PlayerName;
                                }
                            }
                        }
                    }
                }
            }
        }





    }
}