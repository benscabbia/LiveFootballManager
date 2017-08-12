using UnityEngine;

public class Ball : MonoBehaviour
{


    private float lastTimeTicked;
    private BallLocation location = BallLocation.IN_FIELD_CENTER;

    //public InspectableVectorPoint TargetPositonInspectable;
    //private RectPoint targetPosition;
    //public bool inTransfer = false;
    private Player controller;
    public Player LastWhoTouched;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
