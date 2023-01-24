using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public GameObject target; // El objeto a seguir
    public float smoothSpeed = 0.125f; // La velocidad de suavizado
    public Vector2 minPos, maxPos; // Límites de la cámara en el eje X e Y

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.transform.position; // Calcula la posición deseada de la cámara
        desiredPosition.x = Mathf.Clamp(desiredPosition.x, minPos.x, maxPos.x); // Limita la posición en X
        desiredPosition.y = Mathf.Clamp(desiredPosition.y, minPos.y, maxPos.y); // Limita la posición en Y

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Suaviza la posición
        transform.position = smoothedPosition; // Asigna la posición suavizada a la cámara
    }
}
