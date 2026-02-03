using UnityEngine;

public class AltFollowPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = player.transform.position + offset;
            
    }

    public GameObject player;
    public Vector3 offset = new Vector3(2, 3, -2);
    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            transform.position = player.transform.position + offset;
             
        }
    }
}
