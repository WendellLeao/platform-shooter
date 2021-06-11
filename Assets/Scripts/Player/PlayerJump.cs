using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController playerController;
    private const float JUMP_FORCE = 150f;

    void OnEnable()
    {
        playerController.OnPlayerJumps += OnPlayerJumps_Jump;
    }
    
    private void OnPlayerJumps_Jump()
    {
        playerController.PlayerBody.AddForce(new Vector2(playerController.PlayerBody.velocity.x, JUMP_FORCE));    
    }

    void OnDisable()
    {
        playerController.OnPlayerJumps -= OnPlayerJumps_Jump;
    }
}
