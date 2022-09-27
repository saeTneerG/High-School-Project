using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Transform Player;
    public Transform respawnPos;

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name == "Player"){
            Player.position = respawnPos.position;
        }
        else if(col.gameObject.name == "FallenGround"){
            Destroy(col.gameObject);
        }
    }
}
