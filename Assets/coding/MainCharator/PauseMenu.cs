using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public GameObject menuPause;
    public GameObject SettingMenu;
    public GameObject PauseMenuUI;
    
    public static bool GameIsPause = false;
     public static bool settingIsActive = false;

    public int iLevelToLoad;

    void Update()
    {

        if(Quest2.MiniGame == true)
            return;
        
        if(settingIsActive == true || GameIsPause == false){
            if(Input.GetKeyDown(KeyCode.Escape)){
                if(GameIsPause == true && settingIsActive == false){
                    Resume();
                }
                else{
                    Pause();
                }
            }
        }
    }

    public void Resume(){
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    void Pause(){
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void Setting(){
        settingIsActive = true;
        SettingMenu.SetActive(true);
        menuPause.SetActive(false);
    }

    public void QuitGame(){
        SceneManager.LoadScene(iLevelToLoad);
        Debug.Log("Quitting Game...");
        DataPersistenceManagement.instance.SaveGame();
    }

    public void SetVolume(float volume){
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullScreen){
        Screen.fullScreen = isFullScreen;
    }

}
