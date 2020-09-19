using Assets.Scripts.Core;
using Assets.Scripts.Interfaces;
using System;
using UnityEngine;
using UnityEngine.Assertions;

public class Bullet : AsteroidGameObject, IKillable
{
    public float MoveSpeed = 10;
    public float MINIMUM_SPEED_THRESHOLD;

    private Rigidbody2D rigidBody;
    private readonly Vector2 SLOWING_FACTOR = new Vector2(0.98f, 0.98f);

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        Assert.IsTrue(MINIMUM_SPEED_THRESHOLD != 0.0f);

        rigidBody.velocity = transform.up * MoveSpeed;
    }

    void Update()
    {
        if(IsTooSlow())
        {
            Die();
        }
    }

    private bool IsTooSlow()
    {
        return rigidBody.velocity.magnitude <= MINIMUM_SPEED_THRESHOLD;
    }

    void FixedUpdate()
    {
        rigidBody.velocity = rigidBody.velocity * SLOWING_FACTOR;    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
