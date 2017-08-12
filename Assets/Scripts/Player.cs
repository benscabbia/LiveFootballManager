using UnityEngine;

public class Player
{

    public GameObject sprite;

    public Team team;

    public Player(int number, PlayerPosition position, Team team)
    {
        Number = number;

        Position = position;

        this.team = team;
        SetInitialPosition();


    }

    private void SetInitialPosition()
    {
        // left site of pitch        
        if (this.Position == PlayerPosition.GOALKEEPER)
        {
            if (team.Index == 0)
            {
                this.CurrentPosition = new Vector2(1, 17);
            }
            else
            {
                this.CurrentPosition = new Vector2(53, 17);
            }
        }

    }

    public string Name { get { return Number.ToString(); } }
    public int Number { get; set; }
    public PlayerPosition Position { get; set; }
    public float Speed { get; set; }
    public int Strength { get; set; }
    public int Control { get; set; }
    //public RectPoint CurrentPosition { get; set; }
    public Vector2 CurrentPosition { get; set; }
    public Ball ball { get; set; }


}
