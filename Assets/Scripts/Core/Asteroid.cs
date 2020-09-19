using Assets.Scripts.Core;
using Assets.Scripts.Interfaces;
using UnityEngine;

public class Asteroid : AsteroidGameObject, IKillable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
