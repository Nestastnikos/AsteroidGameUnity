using UnityEngine;

namespace Assets.Scripts.Core.Spaceship
{
    public class SpaceShipWeapon : MonoBehaviour
    {
        public GameObject bulletPrefab;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
