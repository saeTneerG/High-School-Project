using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnglsihToLoop : MonoBehaviour
{
    public GameObject Eng;
    public GameObject Loop;
    public GameObject cam;

    public Transform Player;
    public Transform Position;

    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    void Update()
    {
        if(IsDetected() && Input.GetKeyDown(KeyCode.E)){
            cam.SetActive(false);
            Eng.SetActive(false);
            Loop.SetActive(true);
            Player.position = Position.position;
        }
    }

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }
}
