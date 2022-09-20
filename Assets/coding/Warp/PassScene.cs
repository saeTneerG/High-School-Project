using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassScene : MonoBehaviour
{

    public int iLevelToLoad;
    public string sLevelToLoad;

    public bool useTriggerToLoadLevel = false;

    public void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            passScene();
        }
    }

    void passScene(){
        if(useTriggerToLoadLevel){
            SceneManager.LoadScene(iLevelToLoad);
        }
        else{
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
    
}
