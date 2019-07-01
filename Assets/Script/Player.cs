using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool moveFlg;
    bool upDerection,downDerection, rightDerection, leftDerection;

    // Start is called before the first frame update
    void Start(){
        moveFlg = false;
        upDerection = downDerection = rightDerection = leftDerection = false;
    }

    // Update is called once per frame
    void Update(){
        
        PlayerDerection();
        if(moveFlg == true)
        {
            PlayerRun();
        }
    }

    public void PlayerDerection()
    {

        if (Input.GetKey(KeyCode.W))
        {
            moveFlg = true;
            upDerection = true;
            downDerection = rightDerection = leftDerection = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveFlg = true;
            leftDerection = true;
            downDerection = rightDerection = upDerection = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            moveFlg = true;
            downDerection = true;
            upDerection = rightDerection = leftDerection = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveFlg = true;
            rightDerection = true;
            downDerection = upDerection = leftDerection = false;
        }
    }

    private void  PlayerRun(){
        float key = 0.0f;

        Transform myTransform = this.transform;
        Vector3 pos = transform.position;

        if (upDerection == true){
            key = 0.0f;
            pos.y += 0.07f; 
        }
        if (leftDerection == true)
        {
            key = 90.0f;
            pos.x -= 0.07f;
        }
        if (downDerection == true)
        {
            key = 180.0f;
            pos.y -= 0.07f;
        }
        if (rightDerection == true)
        {
            key = 270.0f;
            pos.x += 0.07f;
        }
        transform.localRotation = Quaternion.Euler(0.0f, 0.0f, key);
        myTransform.position = pos;
    }

    private void OnCollisionStay(Collision collision)
    {
        moveFlg = false;
    }
}
