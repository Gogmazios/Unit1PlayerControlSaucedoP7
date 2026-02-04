using UnityEngine;

public class Altfollowplayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public GameObject nonplayer;
    private Vector3 offset = new Vector3(2, 3, -1);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = nonplayer.transform.position + offset;

    }
}
