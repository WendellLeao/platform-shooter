using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController playerController;
    private const float MOVE_SPEED = 6f;
    
    void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float movementInput = playerController.PlayerInput.Land.Move.ReadValue<float>();

        if(movementInput > 0f)
        {
            playerController.PlayerBody.velocity = new Vector2(
                +MOVE_SPEED, playerController.PlayerBody.velocity.y);
        }
        else if(movementInput < 0f)
        {
            playerController.PlayerBody.velocity = new Vector2(
                -MOVE_SPEED, playerController.PlayerBody.velocity.y);
        }
        else
        {
            playerController.PlayerBody.velocity = new Vector2(
                0f, playerController.PlayerBody.velocity.y);
        }
    }
}
