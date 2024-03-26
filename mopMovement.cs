using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mopMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float gridSize = 1f;

    private Vector3 targetPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            MoveToGridPosition(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            MoveToGridPosition(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            MoveToGridPosition(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            MoveToGridPosition(Vector3.down);
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    void MoveToGridPosition(Vector3 direction)
    {
        targetPosition = transform.position + direction * gridSize;
    }
}
