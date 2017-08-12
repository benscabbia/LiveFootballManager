using UnityEngine;

public abstract class PlayerState
{
    protected Player player { get; set; }
    public bool Running { get; set; }

    public bool LosesBallOnCompletion { get; set; }
    public bool DirectlyInvolvedInAction { get; set; }
    public bool NeedsBallOnEntering { get; set; }

    public virtual void Perform()
    {
        Debug.Log("Perfoming Player state");
    }
}
