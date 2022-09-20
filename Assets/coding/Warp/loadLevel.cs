using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{

    public int LevelToLoad;

    public const float detectionRadius = 0.5f;
    public LayerMask detectionLayer;

    void Update()
    {
        if(DetectWarp()){
            if(Input.GetKeyDown(KeyCode.W)){
                LoadScene();
                Debug.Log("LoadLevel...");
            }
        }
    }

    bool DetectWarp(){
        return Physics2D.OverlapCircle(transform.position, detectionRadius, detectionLayer);
    }

    void LoadScene(){
        SceneManager.LoadScene(LevelToLoad);
    }

    private void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, detectionRadius);
    }

    
}
