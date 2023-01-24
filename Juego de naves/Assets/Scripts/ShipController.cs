using UnityEngine;

public class ShipController : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    private Rigidbody2D shipRbody;
    private Vector2 movement;

    void Start()
    {
        shipRbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(movX, movY).normalized;
    }

    void FixedUpdate()
    {
        shipRbody.MovePosition(shipRbody.position + movement * speed * Time.fixedDeltaTime);
    }

}
