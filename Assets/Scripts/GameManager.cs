using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;              //Static instance of GameManager which allows it to be accessed by any other script.
    private PitchManager pitchManager;

    // Use this for initialization
    void Awake()
    {
        //if not, set instance to this
        if (instance == null)
        {
            instance = this;
        }
        //If instance already exists and it's not this:
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }


        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        pitchManager = GetComponent<PitchManager>();
        InitGame();
    }

    private void InitGame()
    {
        pitchManager.SetupPitch();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
