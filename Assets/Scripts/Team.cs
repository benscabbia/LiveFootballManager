using System.Collections.Generic;

public class Team
{

    public int Index { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
    //public InspectableVectorPoint MyProperty { get; set; }
    public GoalKeeper Keeper { get; set; }
    public List<Player> PlayersInGame { get; set; }
    //public List<Player> Players { get; set; }

    // Use this for initialization


    public Team(string name, int index)
    {

        Index = index;
        PlayersInGame = new List<Player>();

        for (int i = 0; i < 11; i++)
        {

            //1 gk, 4 defenders, 4 mid, 2 attac 442
            Player player;
            if (i == 0) player = new Player(i + 1, PlayerPosition.GOALKEEPER, this);
            else if (i < 5) player = new Player(i + 1, PlayerPosition.DEFENDER, this);
            else if (i < 10) player = new Player(i + 1, PlayerPosition.MIDFIELDER, this);
            else
            {
                player = new Player(i + 1, PlayerPosition.ATTACKER, this);
            }
            PlayersInGame.Add(player);
        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
