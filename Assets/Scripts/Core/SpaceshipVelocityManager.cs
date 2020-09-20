using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Scripts.Core
{
    public class SpaceshipVelocityManager : MonoBehaviour
    {

        public float SlowingFactor = 0.95f;
        public float MaxSpeed = 20f;

        private Rigidbody2D rigidBody;
        private SpaceshipState state;

        void Start()
        {
            Assert.IsTrue(SlowingFactor != 0.0f);
            Assert.IsTrue(MaxSpeed != 0.0f);

            rigidBody = GetComponent<Rigidbody2D>();
            state = GetComponent<SpaceshipState>();
        }

        private bool IsMaxSpeedExceeded()
        {
            return rigidBody.velocity.magnitude >= MaxSpeed;
        }

        private void FixedUpdate()
        {
            SlowTheMovement();
            state.IsThrustEnabled = !IsMaxSpeedExceeded();
        }

        private void SlowTheMovement()
        {
            rigidBody.velocity = rigidBody.velocity * SlowingFactor;
        }
    }
}
