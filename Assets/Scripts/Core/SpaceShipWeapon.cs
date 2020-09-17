using Assets.Scripts.Interfaces;
using UnityEngine;

public class SpaceShipWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
