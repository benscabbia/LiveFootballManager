public class Crossing : PlayerState
{

    public Crossing(Player player)
    {
        DirectlyInvolvedInAction = true;
        LosesBallOnCompletion = true;
        NeedsBallOnEntering = true;
    }

    public override void Perform()
    {
        base.Perform();
    }

}
