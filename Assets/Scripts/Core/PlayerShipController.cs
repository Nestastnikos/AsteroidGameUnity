using Assets.Scripts.Core;
using UnityEngine;

public class PlayerShipController : MonoBehaviour
{
    public float RotationRatio = 5f;
    public float MoveSpeed = 5f;
    
    public Vector3 direction = new Vector3(0,0,1);
    
    private Transform transformRef = null;
    private Rigidbody2D rigidBodyRef = null;

    void Start()
    {
        transformRef = gameObject.GetComponent<Transform>();
        rigidBodyRef = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBodyRef.velocity = transformRef.up * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Quaternion.Euler(0, 0, RotationRatio) * direction;
            transformRef.Rotate(-direction);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Quaternion.Euler(0, 0, RotationRatio) * direction;
            transformRef.Rotate(direction);
        }
    }
}
