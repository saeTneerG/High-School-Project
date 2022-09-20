using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            if(PlayerControler.lightSet == true){
                PlayerControler.lightSet = false;
            }
            else if(PlayerControler.lightSet == false){
                PlayerControler.lightSet = true;
            }
        }
    }
}
