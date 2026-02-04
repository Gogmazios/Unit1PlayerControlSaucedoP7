using UnityEngine;

public class PlayerController : MonoBehaviour
{




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey; 
    private float speed = 35.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput; 
    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //moos ze tank on forward y forwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //moves the tank from side to side aka makes it possibly do the cha cha side
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;

        }
    }
}
