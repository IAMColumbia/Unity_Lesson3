using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public InputAction jumpAction;
    public float jumpForce = 10;
    public float gravityModifier;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
      
        jumpAction.Enable();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
