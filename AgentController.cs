using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
public class AgentController : MonoBehaviour
{

    private float JumpHeight = 5.0f;
    private Rigidbody rb;
    public bool groundedPlayer = true;
    private float groundRadius = 0.3f;
    private Transform groundCheck;
    public LayerMask groundMask; 

    public Transform player;
    

    private float gravityValue = -9.8f;

public GameObject MainCamera; //Ссылка на цель

private NavMeshAgent agent;

Vector3 Dir = Vector3.zero;

private float speed;

private float currentspeed;


void Start(){
    agent = GetComponent<NavMeshAgent>();
    Cursor.visible = false;
}
void Update()
{
    //isGrounded = Physics.OverlapSphere();

if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            groundedPlayer = false;
            agent.enabled = false;
            player.position=new Vector3(player.position.x,player.position.y+Mathf.Sqrt(JumpHeight * -3.0f * gravityValue),player.position.z);

        }
        if ()
         player.position=new Vector3(player.position.x,player.position.y+gravityValue * Time.deltaTime,player.position.z);
    Vector3 offset = new Vector3();
// Задаем цель для агента
    //offset = GetBaseInput()* agent.speed * Time.deltaTime;
    //Debug.Log(!GetBaseInput().Equals(Vector3.zero));
     offset =  GetBaseInput() * agent.speed * Time.deltaTime;
     if (agent.enabled == true){
    agent.Move(offset);
     }
}
private Vector3 GetBaseInput(){

Vector3 destination = new Vector3();

if (Input.GetKey (KeyCode.W)){ 
            destination += MainCamera.transform.forward;
        } 
if (Input.GetKey (KeyCode.S)){ 
            destination += MainCamera.transform.forward * -1; 
        } 
if (Input.GetKey (KeyCode.A)){ 
            destination += -MainCamera.transform.right; 
        } 
if (Input.GetKey (KeyCode.D)){ 
            destination += MainCamera.transform.right; 
        } 
return destination;
}
}