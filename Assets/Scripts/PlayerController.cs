using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

  private float speed = 20.0f;      // forward/backward rate of movement
  private float turnSpeed = 60.0f;  // left/right turn rate

  private float horizontalInput;
  private float verticalInput;

  // Start is called before the first frame update
  void Start() {
        
  }

  // Update is called once per frame
  void Update() {
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");

    // Moves the car forward/backward
    transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

    // Turns the car left and right
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
  }
}
