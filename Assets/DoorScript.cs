using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private PlayerScript keyGrab;
    void Update()
    {
        if (keyGrab.keyCount >= 3)
        {
            Destroy(gameObject);
        }
    }

}
