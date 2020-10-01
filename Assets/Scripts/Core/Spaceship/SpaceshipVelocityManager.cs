using Assets.Scripts.Core.General;
using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Scripts.Core.Spaceship
{
    public class SpaceshipVelocityManager : MonoBehaviour, IMovingRestrictedAdapter
    {

        public float SlowingFactor = 0.95f;
        public float MaxSpeed = 20f;

        public Rigidbody2D MovingBody { get; set; }
        public SpaceshipView State { get; set; }

        void Start()
        {
            Assert.IsTrue(SlowingFactor != 0.0f);
            Assert.IsTrue(MaxSpeed != 0.0f);

            MovingBody = GetComponent<Rigidbody2D>();
            State = GetComponent<SpaceshipView>();
        }

        private bool IsMaxSpeedExceeded()
        {
            return MovingBody.velocity.magnitude >= MaxSpeed;
        }

        private void FixedUpdate()
        {
            SlowTheMovement();
            State.IsThrustEnabled = !IsMaxSpeedExceeded();
        }

        private void SlowTheMovement()
        {
            MovingBody.velocity = MovingBody.velocity * SlowingFactor;
        }
    }
}
