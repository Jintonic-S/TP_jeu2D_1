using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement_Joueur : MonoBehaviour
{
    [SerializeField] private float vitesseMax = 2;
    [SerializeField] private float force = 100;
    [SerializeField] private float jumpForce = 350;
    private float moveInput;
    private bool jump = false;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveInput * force, 0));
        rb.linearVelocityX = Mathf.Clamp(rb.linearVelocityX, -vitesseMax, vitesseMax);
        if (jump)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
        jump = false;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<float>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Jump");
            jump = true;
        }
    }
}
