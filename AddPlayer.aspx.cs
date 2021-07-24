using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HockeyNicholasNieto.PlayerTableAdapters;
namespace HockeyNicholasNieto
{
    public partial class AddPlayer : System.Web.UI.Page
    {


        PlayersDataTableAdapter playerAdap = new PlayersDataTableAdapter();


        Player.PlayersDataDataTable tblPlayers = new Player.PlayersDataDataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            tblPlayers = playerAdap.GetPlayers();
            
        }

        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {
            // int id = 0;
            string playerName = txtPlayerName.Text;
            int jerseyNumber = int.Parse(txtJerseyNumber.Text);
            Boolean jerseyCheck = false;

            for (int i = 0; i < tblPlayers.Count(); i++)
            {
                if (tblPlayers[i].JerseyNumber == jerseyNumber)
                {
                    lblMessage.Text = "2 players cannot have the same jersey number!!";
                    jerseyCheck = true;
                    break;
                }
                
            }

            if(!jerseyCheck)
            {
                int result = playerAdap.InsertQuery(playerName, jerseyNumber);

                if (result == 1)
                {
                    lblMessage.Text = "Player Added!";

                }
                else
                {
                    lblMessage.Text = "Player was not Added";
                }
            }

        
        }
    }
}