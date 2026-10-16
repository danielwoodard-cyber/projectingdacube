using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScript : MonoBehaviour
{
    public InputActionAsset actions;
    public float playerSpeed = 5f;
    private bool isGrounded = true;
    public int keyCount = 0;
    public bool hasWon = false;

    InputAction move, jump;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        move = actions.FindAction("player/move");
        jump = actions.FindAction("player/jump");
    }

    void OnEnable() { jump.performed += OnJump; actions.Enable(); }
    void OnDisable() { jump.performed -= OnJump; actions.Disable(); }

    void FixedUpdate()
    {
        Vector2 input = move.ReadValue<Vector2>();
        transform.Translate(new Vector3(input.x, 0, input.y) * playerSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("grounded");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("in the air");
        }
    }
    void OnJump(InputAction.CallbackContext ctx)
    {
        if (isGrounded == true)
        {
         rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}
