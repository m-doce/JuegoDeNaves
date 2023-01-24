using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{

    private Transform cameraTransform; //Creo una variable para guardar en ella el componente transdorm de la camara
    private Vector3 previousCameraPosition; //Esta variable la uso para diferenciar la posicion de la camara entre distintos frames
    [SerializeField] private float parallaxMultiplier; //Valor entre 0 y 1 para disminuir o aumentar el efecto visual de movimiento respectivamente
    private float spriteHeight; //Para guardar el alto total del sprite
    private float startPosition; //Para guardar la posicion inicial del objeto(que lleve el script)

    void Start()
    {
        //Aca asigno a cada variable su respectivo componente o propiedad
        cameraTransform = Camera.main.transform;
        previousCameraPosition = cameraTransform.position;
        spriteHeight = GetComponent<SpriteRenderer>().bounds.size.y;
        startPosition = transform.position.y;
    }

    void LateUpdate()
    {
        //Con deltaY estoy calculando la diferencia de movimiento que tiene la posicion actual de la camara con su posicion anterior respecto al movimiento en el eje Y, y al multiplicarla por numeros entre 0 y 1 se acentua o decrece la velocidad de movimiento de la camara
        //Luego aplico este movimiento sobre el eje Y al objeto que contiene el script, y finalmente actualizo el valor previo de la camara dandole el valor que tiene en cada frame
        //Con moveAmount estoy calculando cuanto se movio la camara con respecto a la capa sobre la cual se aplica el efecto parallax. En ella obtengo el valor contrario en cuanto a porcentaje de movimiento de la capa con respecto al movimiento de la camara que asigne anteriormente con el multiplicador. A partir de este valor, luego puedo reposicionar las capas por delante o detras del Player, segun sea necesario. Esto lo calculo con los if, en los que reposiciono las capas reasignandoles su posicion (eje Y) en la escena en funcion al movimiento de la camara
        float deltaY = (cameraTransform.position.y - previousCameraPosition.y) * parallaxMultiplier;
        float moveAmount = cameraTransform.position.y * (1 - parallaxMultiplier);
        transform.Translate(new Vector3(0, deltaY, 0));
        previousCameraPosition = cameraTransform.position;

        if(moveAmount > startPosition + spriteHeight){
            transform.Translate(new Vector3(0, spriteHeight, 0));
            startPosition += spriteHeight;
        }
        else if(moveAmount < startPosition - spriteHeight){
            transform.Translate(new Vector3(0, -spriteHeight, 0));
            startPosition -= spriteHeight;
        }
    }

}
