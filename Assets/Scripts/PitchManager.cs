using System.Collections.Generic;
using UnityEngine;

public class PitchManager : MonoBehaviour
{


    // Unity Properties
    public int pitchColumns = 54;
    public int pitchRows = 34;

    public GameObject whiteLine;
    public GameObject goalPost;
    public GameObject middleLine;
    public GameObject[] pitchGrassTile;

    public bool outsidePitchSetup = true;
    public bool squares = false;


    private Transform pitchHolder;
    private Transform outerPitchHolder;
    private Transform pitchGraphics;

    private List<Vector3> gridPositions = new List<Vector3>();


    private void InitializeList()
    {
        gridPositions.Clear();
        for (int x = 0; x < pitchColumns; x++)
        {
            for (int y = 0; y < pitchRows; y++)
            {
                gridPositions.Add(new Vector3(x, y, 0));
            }
        }
    }

    private void PitchSetup()
    {
        pitchHolder = new GameObject("Pitch").transform;

        for (int x = 0; x < pitchColumns; x++)
        {

            for (int y = 0; y < pitchRows; y++)
            {


                GameObject toInstantiate, instance;

                if ((y % 2 == 0 && x % 2 == 0 && squares) || (!squares && x % 2 == 0))
                {
                    toInstantiate = pitchGrassTile[0];
                }
                else
                {
                    toInstantiate = pitchGrassTile[1];
                }

                // draw line if on the edge 
                if (x == 0 || x == pitchColumns - 1 || y == 0 || y == pitchRows - 1)
                {
                    toInstantiate = whiteLine;
                }

                //draw center line 
                if (x == pitchColumns / 2)
                {
                    toInstantiate = middleLine;
                }

                // Check if we are either side of pitch to draw goals
                if (x == 0 || x == pitchColumns - 1)
                {
                    var middle = pitchRows / 2;
                    if (middle == y)
                    {
                        // Temp hack to color either side of post
                        toInstantiate = goalPost;
                    }
                    else if (middle == y - 1 || middle == y - 2 || middle == y + 1 || middle == y + 2)
                    {
                        toInstantiate = goalPost;
                    }
                }




                instance = Instantiate(toInstantiate, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                instance.transform.SetParent(pitchHolder);
            }
        }
    }
    private void OutsidePitchSetup()
    {
        outerPitchHolder = new GameObject("OuterPitch").transform;

        for (int x = -5; x < pitchColumns + 5; x++)
        {

            for (int y = -5; y < pitchRows + 5; y++)
            {
                // tidy up to only render where no tiles
                GameObject instance = Instantiate(pitchGrassTile[1], new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                instance.transform.SetParent(outerPitchHolder);

            }
        }
    }

    public void SetupPitch()
    {
        if (outsidePitchSetup) OutsidePitchSetup();
        PitchSetup();
        InitializeList();
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
