
using System.Collections.Generic;

public class Team
{
    private bool initialized = false;
    public int Index { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
    //public InspectableVectorPoint MyProperty { get; set; }
    public GoalKeeper Keeper { get; set; }
    public List<Player> PlayersInGame { get; set; }
    //public List<Player> Players { get; set; }

    // Use this for initialization
    public AbstractTactic Tactic { get; set; }

    public Team(string name, int index, AbstractTactic tactic)
    {

        Index = index;
        PlayersInGame = new List<Player>();
        Tactic = tactic;
        tactic.SetInitialPositions(this);
    }
}
