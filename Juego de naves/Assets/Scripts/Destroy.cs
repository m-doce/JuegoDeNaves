using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletRb;
    [SerializeField] private float speed;

    void Start()
    {
        bulletRb.velocity = Vector2.up * speed;
    }

    private void OnCollisionEnter2D(){
        Destroy(gameObject);
    }

}
