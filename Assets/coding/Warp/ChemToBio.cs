using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemToBio : MonoBehaviour
{

    public GameObject Chemical;
    public GameObject Biological;

    public Transform Player;
    public Transform Position;

    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    void Update()
    {
        if(IsDetected() && Input.GetKeyDown(KeyCode.E) && Quest1.ChemClear == true){
            Chemical.SetActive(false);
            Biological.SetActive(true);
            Player.position = Position.position;
        }
    }

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }

}
