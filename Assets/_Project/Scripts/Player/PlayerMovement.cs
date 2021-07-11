using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController _playerController;
    
    private const float MOVE_SPEED = 6f;
    
    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float movementInput = _playerController.PlayerInput.Land.Move.ReadValue<float>();

        if(movementInput > 0f)
        {
            _playerController.PlayerBody.velocity = new Vector2(
                +MOVE_SPEED, _playerController.PlayerBody.velocity.y);
        }
        else if(movementInput < 0f)
        {
            _playerController.PlayerBody.velocity = new Vector2(
                -MOVE_SPEED, _playerController.PlayerBody.velocity.y);
        }
        else
        {
            _playerController.PlayerBody.velocity = new Vector2(
                0f, _playerController.PlayerBody.velocity.y);
        }
    }
}
