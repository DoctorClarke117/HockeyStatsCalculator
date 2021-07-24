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
    public partial class EditPlayer : System.Web.UI.Page
    {
        PlayersDataTableAdapter playerAdap = new PlayersDataTableAdapter();
        PlayersTable tblPlayers = new PlayersTable();
        StatisticTableAdapter statsAdap = new StatisticTableAdapter();
        StatsTable tblStats = new StatsTable();



        public void searchPlayer()
        {
            string player = txtSearchPlayers.Text;
            tblPlayers = playerAdap.FindPlayer(player);

            for (int i = 0; i < tblPlayers.Count(); i++)
            {
                rdioMatchesPlayers.Items.Add(tblPlayers[i].PlayerName);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                searchPlayer();
            }
        }

        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {

            int id = tblPlayers[rdioMatchesPlayers.SelectedIndex].PlayerId;
        
            int result = 0;

            string playerName = txtEditPlayerName.Text;
            int jerseyNumber = int.Parse(txtEditJerseyNumber.Text);

            Boolean jerseyCheck = false;

            for (int i = 0; i < tblPlayers.Count(); i++)
            {
                if (tblPlayers[i].JerseyNumber == jerseyNumber)
                {
                    lblEditMessage.Text = "2 players cannot have the same jersey number!!";
                    jerseyCheck = true;
                    break;
                }

            }

            if (!jerseyCheck)
            {
                result = playerAdap.UpdatePlayer(playerName, jerseyNumber, id);


                if (result == 1)
                {
                    lblEditMessage.Text = "Player has been edited!";

                }
                else
                {
                    lblEditMessage.Text = "Failed to edit player!";
                }


            }


              

        }

        protected void btnDeletePlayer_Click(object sender, EventArgs e)
        {

            int id = tblPlayers[rdioMatchesPlayers.SelectedIndex].PlayerId;

            statsAdap.DeleteStats(id);
            playerAdap.DeletePlayer(id);
            lblEditMessage.Text = "Player has been deleted!";


        }
    }
}