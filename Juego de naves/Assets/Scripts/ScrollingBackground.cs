using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Renderer bgRenderer;
    


    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
}

/*
Primero defino dos variables, una para la velocidad de movimiento del fondo, y la otra para su mesh renderer
A estas les asigno sus valores dentro del inspector de Unity
Las imágenes que voy a usar de fondo deben tener el valor "Repeat" en su propiedad "Wrap Mode"
Para el material, en su propiedad "Shader" debo asignar el valor "Unlit/Texture" o "Unlit/Transparent" según corresponda
Estos materiales deben ir dentro de un objeto 3D "Quad". Al mismo hay que variarle su posición el eje Z para superponer los distintos fondos entre sí
Por último en el Update, le sumo a mi fondo la velocidad a la que quiero que se desplaze, y éste se repite continuamente
*/