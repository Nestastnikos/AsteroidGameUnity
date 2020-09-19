using Assets.Scripts.Core;
using Assets.Scripts.Interfaces;
using UnityEngine;

public class Asteroid : AsteroidGameObject, IKillable
{
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -0.1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
