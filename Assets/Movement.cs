using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rb;

    float horizontal;
    float vertical;

    public float Vel = 5f;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * Vel, vertical * Vel);
    }
}