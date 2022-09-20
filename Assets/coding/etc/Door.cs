using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Plank;
    public Animator transistion;
    public Animator text1;
    public GameObject canVas;
    public GameObject Sos;

    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    public static bool canGo = false;
    
    void Update()
    {   
       if(IsDetected() && Input.GetKeyDown(KeyCode.E) && canGo != true && DoorLoop.x1 == false){
           Plank.SetActive(true);
           DoorLoop.x1 = true;
           Destroy(this);
       }
       else if(IsDetected() && Input.GetKeyDown(KeyCode.E) && canGo != true && DoorLoop.x2 == false){
           Plank.SetActive(true);
           DoorLoop.x2 = true;
           Destroy(this);
       }
       else if(IsDetected() && Input.GetKeyDown(KeyCode.E) && canGo != true && DoorLoop.x3 == false){
           Plank.SetActive(true);
           DoorLoop.x3 = true;
           Destroy(this);
       }
       else if(IsDetected() && Input.GetKeyDown(KeyCode.E) && canGo == true){
           canVas.SetActive(true);
           StartCoroutine("Fade");
           Sos.SetActive(false);
       }
    }   

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }

    IEnumerator Fade(){
        transistion.SetTrigger("Start");
        yield return new WaitForSeconds(3f);
        Sos.SetActive(true);
        text1.SetTrigger("Start");
        yield return new WaitForSeconds(10f);
        
    }
}
