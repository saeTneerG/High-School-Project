using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BioToPhys : MonoBehaviour
{
    public GameObject Bios;
    public GameObject Phys;
    public GameObject Ground;

    public Transform Player;
    public Transform Position;

    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    void Update()
    {
        if(IsDetected() && Input.GetKeyDown(KeyCode.E) && Bio.BioClear == true){
            Bios.SetActive(false);
            Phys.SetActive(true);
            Ground.SetActive(false);
            Player.position = Position.position;
        }
    }

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }
}
