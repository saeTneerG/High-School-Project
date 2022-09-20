using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bio : MonoBehaviour
{

    public static bool MiniGame = false;
    public static bool BioClear  = false;

    public GameObject MiniGameMenu;

    public LayerMask detectionLayer;

    void Update()
    {
        if(DetectPlayer()){
            if(Input.GetKeyDown(KeyCode.E) && BioClear == false){
                MiniGameStart();
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape) && MiniGame == true){
            MiniGameEnd();
        }
        else if(MiniGame == false){
            MiniGameEnd();
        }
    }

    bool DetectPlayer(){
        return Physics2D.OverlapCircle(transform.position, 0.5f, detectionLayer);
    }

    public void MiniGameStart(){
        MiniGameMenu.SetActive(true);
        Time.timeScale = 0f;
        MiniGame = true;
    }

    public void MiniGameEnd(){
        MiniGameMenu.SetActive(false);
        Time.timeScale = 1f;
        MiniGame = false;
    }

    public void Pass(){
        MiniGame = false;
        BioClear = true;
        Time.timeScale = 1f;
    }
}
