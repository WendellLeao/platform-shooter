using System;
using UnityEngine;

public sealed class PlayerController : MonoBehaviour
{
    [Header("Player Components")]
    [SerializeField] private PlayerGroundChecker _playerGroundChecker;
    [SerializeField] private BoxCollider2D _playerBoxCollider2D;
    [SerializeField] private PlayerInput _playerInput; 
    [SerializeField] private Rigidbody2D _playerBody;
    
    public PlayerGroundChecker PlayerGroundChecker => _playerGroundChecker;
    public BoxCollider2D PlayerBoxCollider2D => _playerBoxCollider2D;
    public PlayerInput PlayerInput => _playerInput;
    public Rigidbody2D PlayerBody => _playerBody;

    public void Initialize(Rigidbody2D playerBody, PlayerInput playerInput, PlayerGroundChecker playerGroundChecker, BoxCollider2D playerBoxCollider2D)
    {
        _playerBody = playerBody;
        _playerInput = playerInput;
        _playerGroundChecker = playerGroundChecker;
        _playerBoxCollider2D = playerBoxCollider2D;
        
        Awake();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Awake()
    {
        _playerInput = new PlayerInput();  
    }
}