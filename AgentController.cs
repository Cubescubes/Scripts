using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
public Transform target; // Ссылка на цель

private NavMeshAgent agent;

private float speed;

private float currentspeed;

void Start()
{
// Получаем компонент NavMeshAgent
agent = GetComponent<NavMeshAgent>();
speed = 3.5f;
}

void Update()
{

    Vector3 offset = new Vector3();
// Задаем цель для агента
    offset = GetBaseInput()* speed * Time.deltaTime;
    agent.Move(offset);
    if (currentspeed != agent.speed) {
        offset= offset * 2;
    }
    Debug.Log(offset); 

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