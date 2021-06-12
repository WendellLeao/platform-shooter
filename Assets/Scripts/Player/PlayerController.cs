using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Components")]
    [SerializeField] private Rigidbody2D playerBody;
    private PlayerInput playerInput;

    void Awake()
    {
        playerInput = new PlayerInput();    
    }

    void OnEnable()
    {
        playerInput.Enable();
    }
    void OnDisable()
    {
        playerInput.Disable();
    }

    #region Propreties
    public Rigidbody2D PlayerBody
    {
        get{return this.playerBody;}
    }

    public PlayerInput PlayerInput
    {
        get{return this.playerInput;}
    }
    #endregion
}
