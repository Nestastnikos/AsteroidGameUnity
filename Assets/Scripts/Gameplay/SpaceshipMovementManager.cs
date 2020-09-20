using UnityEngine;
using UnityEngine.Assertions;

public class SpaceshipMovementManager : MonoBehaviour
{
    public float RotationRatio = 3f;

    public float SlowingFactor = 0.95f;
    public float MoveSpeed = 1f;
    public float MaxSpeed;

    private bool IsThrustEnabled { get; set; }

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsTrue(SlowingFactor != 0.0f);
        Assert.IsTrue(MaxSpeed != 0.0f);
        Assert.IsTrue(MoveSpeed != 0.0f);
        Assert.IsTrue(RotationRatio != 0.0);

        rigidBody = GetComponent<Rigidbody2D>();
    }

    private bool IsMaxSpeedExceeded()
    {
        return rigidBody.velocity.magnitude >= MaxSpeed;
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = rigidBody.velocity * SlowingFactor;
        IsThrustEnabled = !IsMaxSpeedExceeded();
    }

    public void MoveForward()
    {
        if(IsThrustEnabled)
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
