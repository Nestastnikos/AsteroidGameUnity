using Assets.Scripts.Core;
using UnityEngine;

public class Bullet : AsteroidGameObject
{
    public float MoveSpeed = 10;
    public Rigidbody2D ThisRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ThisRigidBody.velocity = transform.up * MoveSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);    
    }
}
