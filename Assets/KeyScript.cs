using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private PlayerScript PlayScript;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayScript.keyCount++;
            Destroy(gameObject);
        }
    }
   
}
