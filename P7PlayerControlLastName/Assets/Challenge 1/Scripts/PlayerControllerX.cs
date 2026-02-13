using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 15.0f;
    //public float rotationSpeed;
    private float verticalInput;
    private float horizontalInput;
    private float forwardInput;
    private float rotationSpeed; 

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        forwardInput = horizontalInput.GetAxis("Vertical");
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
        transform.Rotate(Vector3.verticalInput * rotationSpeed * Time.deltaTime);




    }
}
