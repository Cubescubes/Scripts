using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{

    
float camSens = 2f;

private Vector3 lastMouse = new Vector3(255, 255, 255);
    Vector3 Dir = Vector3.zero;
    public Transform player; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Dir = transform.forward;
        this.gameObject.transform.position = player.position;
        lastMouse = Input.mousePosition - lastMouse ; 
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0 ); 
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x , transform.eulerAngles.y + lastMouse.y, 0); 
        transform.eulerAngles = lastMouse; 
        lastMouse =  Input.mousePosition;
       // Debug.Log(Dir); 
    }
}