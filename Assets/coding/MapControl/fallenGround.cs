using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallenGround : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
            StartCoroutine("fallDown");
        }
    }

    IEnumerator fallDown(){
        yield return new WaitForSeconds(0.5f);
        rb.isKinematic = false;
    }

}
