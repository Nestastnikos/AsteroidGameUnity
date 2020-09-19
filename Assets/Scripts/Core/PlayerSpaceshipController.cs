using Assets.Scripts.Core;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerSpaceshipController : AsteroidGameObject
{
    public float RotationRatio = 3f;
    public float MoveSpeed = 1f;

    private Transform transformRef = null;
    private Rigidbody2D rigidBody = null;

    private SpaceshipVelocityManager velocityManager;


    void Start()
    {
        Assert.IsTrue(RotationRatio != 0.0);
        Assert.IsTrue(MoveSpeed != 0.0);

        transformRef = gameObject.GetComponent<Transform>();
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        velocityManager = GetComponent<SpaceshipVelocityManager>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) &&
            velocityManager.IsThrustEnabled)
        {
            rigidBody.AddForce(transformRef.up * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateBy(RotationRatio);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateBy(-RotationRatio);
        }
    }

    private void RotateBy(float angle)
    {
        var z = transformRef.rotation.eulerAngles.z + angle;
        transformRef.rotation = Quaternion.Euler(0, 0, z);
    }
}
