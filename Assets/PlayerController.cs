using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
private Rigidbody rb;
int key =0;
    void Start()
    {
        rb = this.transform.GetComponent<Rigidbody> ();
    }

    void Update () {
        Rigidbody rb = this.transform.GetComponent<Rigidbody> ();  // rigidbodyを取得
         if(key ==0){
         //Rigidbody rb = this.transform.GetComponent<Rigidbody> ();  // rigidbodyを取得
         Vector3 force = new Vector3 (0.0f,0.0f,50.0f);    // 力を設定
         if (rb.velocity.magnitude < 20.0f) {
         rb.AddForce (force); 
         }
         }
         if(key ==1){
             Vector3 force2 = new Vector3 (50.0f,0.0f,0.0f);    // 力を設定
             if (rb.velocity.magnitude < 20.0f) {
                 rb.AddForce (force2); 
         }
         }
         if(key==-1){
             Vector3 force2 = new Vector3 (-50.0f,0.0f,0.0f);    // 力を設定
             if (rb.velocity.magnitude < 20.0f) {
                 rb.AddForce (force2);             
         }
         }
        //右側に移動
        if (Input.GetKeyDown (KeyCode.RightArrow)) Right();
            
        //左に移動    
        if (Input.GetKeyDown (KeyCode.LeftArrow)) Left();
        //ジャンプ
        if (Input.GetKeyDown (KeyCode.Space)) Jump();
        //方向転換
        if(Input.GetKeyDown(KeyCode.R))TurnR();
        if(Input.GetKeyDown(KeyCode.L))TurnL();
    }
    
    void Right(){
        Vector3 now = rb.position;
        if (now.x < 2.9){
            now += new Vector3 (3,0,0);
            rb.position = now;
    }
    }
    void Left(){
        Vector3 now = rb.position;
        if(now.x> -3){
            now += new Vector3 (-3,0,0);
            rb.position = now;}
    }
    void Jump(){
        Vector3 now = rb.position;
        if(now.y==0.5){
        rb.velocity = new Vector3(0, 7, 0);
        }
    }
    void TurnR(){
        rb.velocity= Vector3.zero;
        transform.Rotate(new Vector3(0, 1, 0), 90);
        key +=1;
    }
    void TurnL(){
        rb.velocity= Vector3.zero;
        transform.Rotate(new Vector3(0, -1, 0), 90);
        key -=1;
    }
}

