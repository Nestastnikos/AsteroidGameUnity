using Assets.Scripts.Core;
using UnityEngine;
using UnityEngine.Assertions;

public class SpaceshipMovementManager : MonoBehaviour
{
    public float RotationRatio = 3f;
    public float MoveSpeed = 1f;

    private Rigidbody2D rigidBody;
    private SpaceshipState state;

    void Start()
    {
        Assert.IsTrue(RotationRatio != 0.0);

        rigidBody = GetComponent<Rigidbody2D>();
        state = GetComponent<SpaceshipState>();
    }

    public void MoveForward()
    {
        if(state.IsThrustEnabled)
        {
            rigidBody.AddForce(transform.up * MoveSpeed);
        }
    }

    public void TurnRight()
    {
        RotateBy(-RotationRatio);
    }

    public void TurnLeft()
    {
        RotateBy(RotationRatio);
    }

    private void RotateBy(float angle)
    {
        var z = transform.rotation.eulerAngles.z + angle;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
}
