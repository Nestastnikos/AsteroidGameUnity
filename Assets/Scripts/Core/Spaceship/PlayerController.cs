using Assets.Scripts.Core.General;
using UnityEngine;

namespace Assets.Scripts.Core.Spaceship
{
    public class PlayerController : MonoBehaviour, IMovingRestrictedAdapter
    {
        public Rigidbody2D MovingBody { get; private set; }

        public SpaceshipState State { get; private set; }

        private IMovementManager movementManager;

        void Start()
        {
            MovingBody = GetComponent<Rigidbody2D>();
            State = GetComponent<SpaceshipState>();
            movementManager = new MovementManager(this, State.FuelTank);
        }

        void Update()
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                movementManager.TryMoveForward();
            }
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                movementManager.TryTurnLeft();
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                movementManager.TryTurnRight();
            }
        }
    }
}
