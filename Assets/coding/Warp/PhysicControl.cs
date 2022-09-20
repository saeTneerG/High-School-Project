using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicControl : MonoBehaviour
{
    public GameObject Physic1;
    public GameObject Physic2;

    public Transform Player;
    public Transform Position;

    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    void Update()
    {
        if(IsDetected() && Input.GetKeyDown(KeyCode.E)){
            Physic1.SetActive(false);
            Physic2.SetActive(true);
            Player.position = Position.position;
        }
    }

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }
}

