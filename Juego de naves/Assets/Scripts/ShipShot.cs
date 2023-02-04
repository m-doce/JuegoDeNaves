using UnityEngine;

public class ShipShot : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] Transform direction;


    void Shoot() {
        if(Input.GetButtonDown("Fire1")){
            Instantiate(bulletPrefab, direction.position, direction.rotation);
        }
    }

    void Update()
    {
        Shoot();
    }
}
