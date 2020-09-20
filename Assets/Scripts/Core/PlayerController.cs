using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpaceshipMovementManager movementManager;

    void Start()
    {
        movementManager = GetComponent<SpaceshipMovementManager>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementManager.MoveForward();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementManager.TurnLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementManager.TurnRight();
        }
    }
}
