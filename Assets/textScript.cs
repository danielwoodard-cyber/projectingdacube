using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    [SerializeField] private PlayerScript keyGrab2;
    [SerializeField] private TextMeshProUGUI textKeys;
    void Update()
    {
        int keys = keyGrab2.keyCount;
        textKeys.text = "Keys: " + keys;
    }

}