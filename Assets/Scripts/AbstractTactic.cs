using System;
using System.Collections.Generic;

public abstract class AbstractTactic
{

    public string Name { get; set; }
    //public Dictionary<PlayerPosition, Player> PlayerPosition { get; set; }

    public Dictionary<PlayerPosition, Player> TeamFormationPlayers { get; set; }

    public virtual void SetInitialPositions(Team team)
    {
        throw new NotImplementedException();

    }

}
