using UnityEngine;

public class MovingEntity : MonoBehaviour
{


    public Vector2 Velocity { get; set; }
    public Vector2 Heading { get; set; }
    public Vector2 Side { get; set; }
    public double Mass { get; set; }
    public double MaxSpeed { get; set; }
    public double MaxForce { get; set; }
    public double MaxTurnRate { get; set; }

    public MovingEntity(Vector2 velocity, Vector2 heading, Vector2 side,
                        double mass, double maxSpeed, double maxForce, double maxTurnRate)
    {
        this.Velocity = velocity;
        this.Heading = heading;
        this.Side = side;
        this.Mass = mass;
        this.MaxSpeed = maxSpeed;
        this.MaxForce = maxForce;
        this.MaxTurnRate = maxTurnRate;
    }


    public bool RotateHeadingToFacePosition(Vector2 target)
    {
        // TODO
        return false;
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
