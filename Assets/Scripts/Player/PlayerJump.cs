using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController playerController;
    private const float JUMP_FORCE = 150f;

    void Start()
    {
        playerController.PlayerInput.Land.Jump.performed += _ => PerformJump();
    }
    
    private void PerformJump()
    {
        playerController.PlayerBody.AddForce(new Vector2(playerController.PlayerBody.velocity.x, JUMP_FORCE));    
    }
}
