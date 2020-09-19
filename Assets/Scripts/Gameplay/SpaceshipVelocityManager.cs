using UnityEngine;
using UnityEngine.Assertions;

public class SpaceshipVelocityManager : MonoBehaviour
{
    public float SlowingFactor = 0.99f;
    public bool IsThrustEnabled { get; private set; }

    public float MaxSpeed;

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsTrue(SlowingFactor != 0.0f);
        Assert.IsTrue(MaxSpeed != 0.0f);

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
}
