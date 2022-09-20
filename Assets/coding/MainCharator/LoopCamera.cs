using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopCamera : MonoBehaviour
{

    public bool zoomActive = true;
    public Camera Cam;

    public Transform FirstWall;
    public Transform Secondwall;

    public float dampTime = 0.05f;
    public Vector3 velocity = Vector2.zero;

    public Transform Player;

    private float fixedHeight;

    void Start()
    {
        fixedHeight = transform.position.y;   
    }

    void Update()
    {
        if(Player.position.x >= FirstWall.position.x + 10f && Player.position.x <= Secondwall.position.x - 10f){
            cameraTrack(Player);
        }
    }

    public void cameraTrack(Transform Targets){
        Vector3 point = GetComponent<Camera>().WorldToViewportPoint(Targets.position);
        Vector3 delta = Targets.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f,0.5f,point.z));
        Vector3 destination = transform.position + delta + new Vector3(0, 2.05f, 0);
        destination.y = fixedHeight;
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
    }
}
