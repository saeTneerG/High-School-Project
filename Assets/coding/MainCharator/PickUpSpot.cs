using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpot : MonoBehaviour
{
    public Transform HoldSpot;
    public LayerMask Mask;

    public KeyCode pickUp;

    private GameObject ItemInHold;
    
    void Update()
    {
        if(Input.GetKeyDown(pickUp)){
            if(ItemInHold){
                ItemInHold.transform.position = transform.position;
                ItemInHold.transform.parent = null;
                if(ItemInHold.GetComponent<Rigidbody2D>())
                ItemInHold.GetComponent<Rigidbody2D>().simulated = true;
                ItemInHold = null;
            }
            
            else{
            Collider2D pickUpItem = Physics2D.OverlapCircle(transform.position - new Vector3(0,0.1f,0), 0.5f, Mask);
            if(pickUpItem){
                ItemInHold = pickUpItem.gameObject;
                ItemInHold.transform.position = HoldSpot.position;
                ItemInHold.transform.parent = transform;
                if(ItemInHold.GetComponent<Rigidbody2D>())
                ItemInHold.GetComponent<Rigidbody2D>().simulated = false;
            }
            }
        }
    }

    private void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position - new Vector3(0,0.1f,0), 0.5f);
    }
}
