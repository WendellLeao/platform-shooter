using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController playerController;

    //Movement
    public bool isMovingToRight {get; private set;}
    public bool isMovingToLeft {get; private set;}

    void Update()
    {
        HandleInputMovement();
        HandleInputJump();
    }

    private void HandleInputMovement()
    {
        if(Input.GetKey(KeyCode.A) && !isMovingToRight|| Input.GetKey(KeyCode.LeftArrow) && !isMovingToRight)
        {
            isMovingToLeft = true;
            isMovingToRight = false;
        }
        else if(Input.GetKey(KeyCode.D) && !isMovingToLeft|| Input.GetKey(KeyCode.RightArrow) && !isMovingToLeft)
        {
            isMovingToRight = true;
            isMovingToLeft = false;
        }
        else
        {
            isMovingToRight = false;
            isMovingToLeft = false;
        }
    }

    private void HandleInputJump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            playerController.OnPlayerJumps?.Invoke();
    }
}
