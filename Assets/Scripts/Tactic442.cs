using System.Collections.Generic;
using UnityEngine;

public class Tactic442 : AbstractTactic
{



    public Tactic442()
    {
        this.Name = "4-4-2";
        //this.PlayerPosition = playersAndPosition;
    }

    public Player Goalkeeper { get; set; }

    public List<Player> Defenders { get; set; }
    public List<Player> Midfielders { get; set; }
    public List<Player> Attackers { get; set; }


    public override void SetInitialPositions(Team team)
    {
        TeamFormationPlayers = new Dictionary<PlayerPosition, Player>()
        {
            { PlayerPosition.GOALKEEPER, new Player(1, PlayerPosition.GOALKEEPER, team) },

            { PlayerPosition.LEFT_BACK, new Player(2, PlayerPosition.LEFT_BACK, team) },
            { PlayerPosition.CENTER_BACK_LEFT, new Player(3, PlayerPosition.CENTER_BACK_LEFT, team) },
            { PlayerPosition.CENTER_BACK_RIGHT, new Player(4, PlayerPosition.CENTER_BACK_RIGHT, team) },
            { PlayerPosition.RIGHT_BACK, new Player(5, PlayerPosition.RIGHT_BACK, team) },

            { PlayerPosition.LEFT_MIDFIELDER, new Player(6, PlayerPosition.LEFT_MIDFIELDER, team) },
            { PlayerPosition.CENTER_MIDFIELDER_LEFT, new Player(7, PlayerPosition.CENTER_MIDFIELDER_LEFT, team) },
            { PlayerPosition.CENTER_MIDFIELDER_RIGHT, new Player(8, PlayerPosition.CENTER_MIDFIELDER_RIGHT, team) },
            { PlayerPosition.RIGHT_MIDFIELDER, new Player(9, PlayerPosition.RIGHT_BACK, team) },

            { PlayerPosition.STRIKER_CENTER_LEFT, new Player(10, PlayerPosition.STRIKER_CENTER_LEFT, team) },
            { PlayerPosition.STRIKER_CENTER_RIGHT, new Player(11, PlayerPosition.STRIKER_CENTER_RIGHT, team) }
        };

        //home-team positions
        if (team.Index == 0)
        {
            // Need a get position method?
            TeamFormationPlayers[PlayerPosition.GOALKEEPER].CurrentPosition = new Vector2(1, 8);

            TeamFormationPlayers[PlayerPosition.CENTER_BACK_LEFT].CurrentPosition = new Vector2(5, 8);

        }
        else
        {
            TeamFormationPlayers[PlayerPosition.CENTER_BACK_LEFT].CurrentPosition = new Vector2(45, 8);
            TeamFormationPlayers[PlayerPosition.CENTER_BACK_LEFT].CurrentPosition = new Vector2(40, 8);


        }


    }


}
