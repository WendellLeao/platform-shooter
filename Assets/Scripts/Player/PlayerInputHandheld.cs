using UnityEngine;

public class PlayerInputHandheld : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController playerController;

    [Header("Joystick")]
    [SerializeField] private Joystick joystick;

    //Movement
    public bool isMovingToRight {get; private set;}
    public bool isMovingToLeft {get; private set;}
    
    void Start()
    {
        if(playerController.IsOnHandheldDevice())   
            joystick.gameObject.SetActive(true);
    }

    void Update()
    {
        HandleInputMovement();
        HandleInputJump();
    }

    private void HandleInputMovement()
    {
        if(joystick.Horizontal >= 0.2f)
        {
            isMovingToRight = true;
            isMovingToLeft = false;
        }
        else if(joystick.Horizontal <= -0.2f)
        {
            isMovingToLeft = true;
            isMovingToLeft = false;
        }
        else
        {
            isMovingToLeft = false;
            isMovingToLeft = false;
        }
    }
    
    private void HandleInputJump()
    {

    }
}

