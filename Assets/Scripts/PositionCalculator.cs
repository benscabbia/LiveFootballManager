using UnityEngine;

public class PositionCalculator
{


    private Team team1;
    private Team team2;

    private static PositionCalculator instance;

    public static PositionCalculator Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PositionCalculator();
            }
            return instance;
        }
    }

    public Vector2 InitialPosition(Player player)
    {
        switch (player.Position)
        {
            case PlayerPosition.GOALKEEPER:

                return new Vector2(1, 17);

            case PlayerPosition.LEFT_BACK:
                return new Vector2(5, 17);

        }

        return new Vector2(5, 17);
    }




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
