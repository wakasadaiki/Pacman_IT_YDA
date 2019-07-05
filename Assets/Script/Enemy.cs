using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int[] E_Move = new int[] { 0, 1, 2, 3, 4};
    int[] data = new int[] {1,2,3,4};
    int x = 0;
    int y = 0;
    int i = 0;
    int fps = 0;

    // Start is called before the first frame update
    void Start(){
    ;
    }

    // Update is called once per frame
    void Update() {
        fps++;
        if (fps > 100)
        {
            {
                i++;
                if (i > 3) i = 0;
                EnemyRun();
            }
            fps = 0;
        }

        
       
        EnemyMove();
    }

    private void EnemyRun()
    {
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;

        pos.x += x;
        pos.y += y;

        myTransform.position = pos; 
    }


    private void EnemyMove(){

      
            switch (data[i])
            {
                case 0:
                    x = 0;
                    y = 0;
                    break;
                case 1:
                    x = 0;
                    y = 1;
                    break;
                case 2:
                    x = 1;
                    y = 0;
                    break;
                case 3:
                    x = 0;
                    y = -1;
                    break;
                case 4:
                    x = -1;
                    y = 0;
                    break;
                default:
                    Debug.Log("想定してないエラーは出れtl駒曽田");
                    break;

            }
        

    }
}
