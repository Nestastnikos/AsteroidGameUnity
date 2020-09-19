using Assets.Scripts.Core;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerSpaceshipController : AsteroidGameObject
{
    public float RotationRatio = 3f;
    public float MoveSpeed = 1f;
    
    public Vector3 direction = new Vector3(0,0,1);
    
    private Transform transformRef = null;
    private Rigidbody2D rigidBodyRef = null;

    void Start()
    {
        Assert.IsTrue(RotationRatio != 0.0);
        Assert.IsTrue(MoveSpeed != 0.0);

        transformRef = gameObject.GetComponent<Transform>();
        rigidBodyRef = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidBodyRef.velocity = transformRef.up * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateBy(-RotationRatio);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateBy(RotationRatio);
        }
    }

    private void RotateBy(float angle)
    {
        var z = transformRef.rotation.eulerAngles.z + angle;
        transformRef.rotation = Quaternion.Euler(0, 0, z);
    }
}
