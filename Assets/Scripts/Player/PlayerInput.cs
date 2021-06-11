using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController playerController;

    [Header("Joystick")]
    [SerializeField] private Joystick joystick;

    //Movement
    public bool isMovingToRight {get; private set;}
    public bool isMovingToLeft {get; private set;}

    void Update()
    {
        SetupPlayerInput();
    }

    private void SetupPlayerInput()
    {
        // if(IsOnDesktopDevice())
        // {
        //     HandleInputMovement_OnDesktopDevice();
        //     HandleInputJump_OnDesktopDevice();
        // }
        // else if(IsOnHandheldDevice())
        // {
        //     HandleInputMovement_OnHandleheldDevice();
        //     HandleInputJump_OnHandleheldDevice();
        // }
        // else
        // {
        //     Application.Quit();
        // }

        Debug.Log(joystick.Horizontal);
        HandleInputMovement_OnHandleheldDevice();
        HandleInputJump_OnHandleheldDevice();
    }


    //Desktop Inputs
    private void HandleInputMovement_OnDesktopDevice()
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
    private void HandleInputJump_OnDesktopDevice()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            playerController.OnPlayerJumps?.Invoke();
    }

    
    //Handleheld Inputs
    private void HandleInputMovement_OnHandleheldDevice()
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
    private void HandleInputJump_OnHandleheldDevice()
    {

    }

    
    #region Device Detector
    private bool IsOnDesktopDevice()
    {
        return SystemInfo.deviceType == DeviceType.Desktop;
    }
    private bool IsOnHandheldDevice()
    {
        return SystemInfo.deviceType == DeviceType.Handheld;
    }
    #endregion
}
