using UnityEngine;
using UnityEngine.InputSystem; // Resolves "Keyboard does not exist"

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed) moveHorizontal = -1f;
            if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed) moveHorizontal = 1f;
            if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed) moveVertical = 1f;
            if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed) moveVertical = -1f;
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;
        
        rb.AddForce(movement * moveSpeed, ForceMode.Acceleration);
    }
}