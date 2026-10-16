using UnityEngine;

public class DoorCollider : MonoBehaviour
{
    [SerializeField] private PlayerScript ihatecodin;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ihatecodin.hasWon = true;
        }
    }
   
}
