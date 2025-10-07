using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;

    public Transform cam;
    public float smoothSpeed = 5f;
    public Vector3 camOffset = new Vector3(0, 0, -10);

    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement != Vector2.zero)
            movement.Normalize();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (cam != null)
        {
            Vector3 targetPos = transform.position + camOffset;
            cam.position = Vector3.Lerp(cam.position, targetPos, smoothSpeed * Time.deltaTime);
        }
    }
}
