using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float RotationRatio = 5f;
    public float MoveSpeed = 1f;
    
    public Vector3 direction = new Vector3(0,0,1);
    
    private Transform transformRef = null;

    void Start()
    {
        transformRef = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transformRef.position += transformRef.up * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Quaternion.Euler(0, 0, RotationRatio) * direction;
            transformRef.Rotate(-direction);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Quaternion.Euler(0, 0, RotationRatio) * direction;
            transformRef.Rotate(direction);
        }
    }

    private void RotateBy(float angles)
    {
        
    }
}
