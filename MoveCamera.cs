using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform player; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = player.position;
    }
}