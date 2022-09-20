using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysToEng : MonoBehaviour
{
    public GameObject Phys;
    public GameObject Eng;

    public Transform Player;
    public Transform Position;

    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    void Update()
    {
        if(IsDetected() && Input.GetKeyDown(KeyCode.E)){
            Phys.SetActive(false);
            Eng.SetActive(true);
            Player.position = Position.position;
        }
    }

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }
}
