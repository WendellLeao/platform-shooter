using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerObj;
    public void Destry()
    {
        Destroy(playerObj);
    }
}
