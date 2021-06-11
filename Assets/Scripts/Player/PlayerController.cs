using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Components")]
    [SerializeField] private Rigidbody2D playerBody;
    
    [Header("Player Input")]
    [SerializeField] private PlayerInputDesktop playerInputDesktop;
    [SerializeField] private PlayerInputHandheld playerInputHandleheld;
    private PlayerInput currentPlayerInput = new PlayerInput();
    private Action onPlayerJumps;
    
    void Update()
    {
        HandlePlayerInputDevice();
    }

    private void HandlePlayerInputDevice()
    {
        if(IsOnDesktopDevice())
        {
            currentPlayerInput.IsMovingToRight = playerInputDesktop.isMovingToRight;
            currentPlayerInput.IsMovingToLeft = playerInputDesktop.isMovingToLeft;

            playerInputHandleheld.enabled = false;
        }
        else if(IsOnHandheldDevice())
        {
            currentPlayerInput.IsMovingToRight = playerInputHandleheld.isMovingToRight;
            currentPlayerInput.IsMovingToLeft = playerInputHandleheld.isMovingToLeft;

            playerInputDesktop.enabled = false;
        }
        else
        {
            Application.Quit();
        }
    }

    
    #region Device Detector
    public bool IsOnDesktopDevice()
    {
        return SystemInfo.deviceType == DeviceType.Desktop;
    }
    public bool IsOnHandheldDevice()
    {
        return SystemInfo.deviceType == DeviceType.Handheld;
    }
    #endregion
    
    #region Propreties
    public PlayerInput PlayerInput
    {
        get{return this.currentPlayerInput;}
    }

    public Rigidbody2D PlayerBody
    {
        get{return this.playerBody;}
    }

    public Action OnPlayerJumps
    {
        get{return this.onPlayerJumps;}
        set{this.onPlayerJumps = value;}
    }
    #endregion
}
