using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject Plane; 
    public float speed = 15.0f;
    public float rotationSpeed;
    private float verticalInput;
    //private float horizontalInput;
    private float forwardInput;
   // private float rotationSpeed; 

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt ze plane 


        //forwardInput = horizontalInput.GetAxis("Vertical");
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        // tilt the plane up/down based on up/down arrow keys
        // transform.Translate(Vector3.forward * Time.;;;;;;;;;;deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.forward, verticalInput + rotationSpeed * Time.deltaTime * speed);

        //if (Input.GetKeyDown(KeyCode.E))
      //  {
           // transform.Rotate(Plane.(0, -3, 0)); 
       //}

        //if (Input.GetKeyDown(KeyCode.Q))
       // {
           // transform.Rotate(Plane.(0, 3, 0));
      //  }//
        //Vector3 movement = new Vector3 (Input.GetAxis("Vertical"), 0f);
        // ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;



    }
}
