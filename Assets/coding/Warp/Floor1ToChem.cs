using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor1ToChem : MonoBehaviour
{
    public GameObject floor1;
    public GameObject Chem;

    public Transform Player;
    public Transform Position;

    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    void Update()
    {
        if(IsDetected() && Input.GetKeyDown(KeyCode.E)){
            floor1.SetActive(false);
            Chem.SetActive(true);
            Player.position = Position.position;
        }
    }

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }
}
