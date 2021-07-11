using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public sealed class PlayerGroundChecker : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] private PlayerController playerController;

    [Header("Ground Checker")]
    [SerializeField] private LayerMask whatIsGround;

    public bool IsGrounded()
    {
        float extraHeightText = 0.06f;

        RaycastHit2D raycastHit = Physics2D.BoxCast(
            playerController.PlayerBoxCollider2D.bounds.center, 
            playerController.PlayerBoxCollider2D.bounds.size, 
            0f, Vector2.down, extraHeightText, whatIsGround);

        Color rayColor;
        
        if(raycastHit.collider != null)
            rayColor = Color.green;
        else    
            rayColor = Color.red;

        Debug.DrawRay(playerController.PlayerBoxCollider2D.bounds.center + new Vector3(
            playerController.PlayerBoxCollider2D.bounds.extents.x, 0), Vector2.down * 
            (playerController.PlayerBoxCollider2D.bounds.extents.y + extraHeightText), rayColor);
        
        
        Debug.DrawRay(playerController.PlayerBoxCollider2D.bounds.center - new Vector3(
            playerController.PlayerBoxCollider2D.bounds.extents.x, 0), Vector2.down * 
            (playerController.PlayerBoxCollider2D.bounds.extents.y + extraHeightText), rayColor);
        
        Debug.DrawRay(playerController.PlayerBoxCollider2D.bounds.center - new Vector3(
            playerController.PlayerBoxCollider2D.bounds.extents.x, 
            playerController.PlayerBoxCollider2D.bounds.extents.y + extraHeightText), 
            Vector2.right * (playerController.PlayerBoxCollider2D.bounds.extents.x * 2f), 
            rayColor);

        return raycastHit.collider != null;
    }
}
