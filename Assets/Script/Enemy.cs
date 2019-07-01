using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int[] E_Move = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

    // Start is called before the first frame update
    void Start(){
    ;
    }

    // Update is called once per frame
    void Update() { 
   
    }

    private void EnemyRun()
    {
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;

        myTransform.position = pos; 
    }

    private void EnemyMove(){
    }
}
