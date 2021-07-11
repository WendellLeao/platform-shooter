using UnityEngine;

[RequireComponent(typeof(PlayerGroundChecker))]
public sealed class PlayerJump : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController _playerController;

    private const float JUMP_FORCE = 150f;

    private void Start()
    {
        _playerController.PlayerInput.Land.Jump.performed += _ => PerformJump();
    }
    
    private void PerformJump()
    {
        if(_playerController.PlayerGroundChecker.IsGrounded())
            _playerController.PlayerBody.AddForce(new Vector2(_playerController.PlayerBody.velocity.x, JUMP_FORCE));    
    }
}
