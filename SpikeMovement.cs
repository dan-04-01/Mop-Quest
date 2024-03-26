using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    // Speed of movement
    public float moveSpeed = 2f;

    // Amplitude of the sine wave
    public float amplitude = 2f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the vertical movement using a sine wave
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * amplitude;

        // Calculate the movement direction based on the sine wave
        Vector3 movement = new Vector3(0f, verticalMovement, 0f) * Time.deltaTime;

        // Apply movement to the object
        transform.Translate(movement);
    }
}
