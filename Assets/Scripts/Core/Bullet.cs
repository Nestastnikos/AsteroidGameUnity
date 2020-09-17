using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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
        Debug.Log(collision.gameObject.name);
        Destroy(gameObject);    
    }
}
