using UnityEngine;

public class WheelchairMovement : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float turnSpeed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // �leri ve geri hareket
        float moveInput = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * moveInput * forwardSpeed);

        // D�n�� hareketi
        float turnInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, turnInput * turnSpeed, 0);
    }
}
