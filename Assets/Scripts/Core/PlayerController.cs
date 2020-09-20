using Assets.Scripts.Core;
using Assets.Scripts.Gameplay;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpaceshipActionManager actionManager;

    void Start()
    {
        actionManager = GetComponent<SpaceshipActionManager>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            actionManager.TryMoveForward();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            actionManager.TryTurnLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            actionManager.TryTurnRight();
        }
    }
}
