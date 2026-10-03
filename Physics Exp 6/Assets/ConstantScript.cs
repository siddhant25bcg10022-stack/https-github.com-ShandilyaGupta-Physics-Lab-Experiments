using UnityEngine;

public class ConstantMover : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 initialDirection = Vector3.forward;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Set initial velocity
        rb.linearVelocity = initialDirection.normalized * speed;
    }

    void FixedUpdate()
    {
        // Maintain constant speed without altering collision physics direction
        if (rb.linearVelocity.sqrMagnitude > 0)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * speed;
        }
    }
}