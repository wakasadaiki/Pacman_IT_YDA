using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        PlayerRun();
    }

   private void  PlayerRun(){
        Transform myTransform = this.transform;
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W)){
            pos.y += 0.05f; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= 0.05f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= 0.05f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += 0.05f;
        }
        myTransform.position = pos;
    }
}
