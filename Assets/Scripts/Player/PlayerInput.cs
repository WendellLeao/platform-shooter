using UnityEngine;

public class PlayerInput
{
    private bool isMovingToRight;
    private bool isMovingToLeft;

    public bool IsMovingToRight
    {
        get{return this.isMovingToRight;}
        set{this.isMovingToRight = value;}
    }

    public bool IsMovingToLeft
    {
        get{return this.isMovingToLeft;}
        set{this.isMovingToLeft = value;}
    }
}
