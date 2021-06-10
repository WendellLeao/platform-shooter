using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Components")]
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private Rigidbody2D playerBody;
    private Action onPlayerJumps;


    #region Propreties
    public PlayerInput PlayerInput
    {
        get{return this.playerInput;}
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
