using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

public GameObject player;

private Vector3 offset;

int key =0;

void Start ()
{
    offset = transform.position - player.transform.position;
}

void LateUpdate ()
{
    if (key==0){
        transform.position = player.transform.position + offset;
        }
    if(key==1){
        transform.position = player.transform.position;
    }
    if(key==-1){
        transform.position =player.transform.position;
    }
    if(Input.GetKeyDown(KeyCode.R))TurnR();
    if(Input.GetKeyDown(KeyCode.L))TurnL();
}
void TurnR(){
    GameObject.Find("MainCamera").transform.rotation=Quaternion.Euler(0,90,0);
    key+=1;
}
void TurnL(){
    GameObject.Find("MainCamera").transform.rotation=Quaternion.Euler(0,-90,0);
    key-=1;   
}
}

