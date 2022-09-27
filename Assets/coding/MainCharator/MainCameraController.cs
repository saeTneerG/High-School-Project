using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour,IDataPersistence
{

    public bool zoomActive = true;
    public Camera Cam;

    public Transform FirstWall;
    public Transform Secondwall;

    public float secondwall;

    public float dampTime = 0.05f;
    public Vector3 velocity = Vector2.zero;

    public Transform Player;
    public Transform firstTarget;
    public Transform secondTarget;
    public Transform ThirdTarget;

    private float fixedHeight;

    private int i;

    public void LoadData(GameData data){
        Player = data.camTarget;
    }

    public void SaveData(GameData data){
        data.camTarget = Player;
    }

    void Start()
    {
        secondwall = Secondwall.position.x  - 12f;

        Cam = Camera.main;

        fixedHeight = transform.position.y;
    }

    void Update()
    {
        if(Player.position.x > FirstWall.position.x && Player.position.x < Secondwall.position.x){
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 5f, 0.025f);
            cameraTrack(firstTarget);
        }

        else if(Player.position.x < FirstWall.position.x){
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 5f, 0.025f);
            cameraTrack(secondTarget);
        }

        else if(Player.position.x > Secondwall.position.x){
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 5f, 0.025f);
            cameraTrack(ThirdTarget);
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