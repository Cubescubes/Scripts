using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{

public GameObject MainCamera; // Ссылка на цель

Vector3 Dir = Vector3.zero;

private NavMeshAgent agent;

private float speed;

private float currentspeed;

void Start(){
    agent = GetComponent<NavMeshAgent>();
}

void Update()
{
    Dir = Vector3.Normalize(MainCamera.transform.forward);
    Debug.Log(Dir);
    Vector3 offset = new Vector3();
// Задаем цель для агента
    //offset = GetBaseInput()* agent.speed * Time.deltaTime;
    //Debug.Log(!GetBaseInput().Equals(Vector3.zero));
    if( !GetBaseInput().Equals(Vector3.zero) ){
    offset =  GetBaseInput() * agent.speed * Time.deltaTime;
    
    //Debug.Log(Dir + GetBaseInput());
    //cameraInput();
    //Debug.Log(Input.mousePosition); 
    }
    offset =  Dir * agent.speed * Time.deltaTime;
    agent.Move(offset);
}
private Vector3 GetBaseInput(){

Vector3 destination = new Vector3();

if (Input.GetKey (KeyCode.W)){ 
            destination += Vector3.forward;              
        } 
if (Input.GetKey (KeyCode.S)){ 
            destination += new Vector3(0, 0, -1); 
        } 
if (Input.GetKey (KeyCode.A)){ 
            destination += new Vector3(-1, 0, 0); 
        } 
if (Input.GetKey (KeyCode.D)){ 
            destination += new Vector3(1, 0, 0); 
        } 
return destination;
}



}