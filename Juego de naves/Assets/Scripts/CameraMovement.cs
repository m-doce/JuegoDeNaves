using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    private Transform cameraTransform;
    [SerializeField] private float speed;

    void Start()
    {
        cameraTransform = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.position += Vector3.up * speed * Time.deltaTime;
    }
}
