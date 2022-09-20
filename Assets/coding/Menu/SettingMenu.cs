using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject Menu;

    public AudioMixer audioMixer;

    void Update(){
        if(PauseMenu.settingIsActive == true){
            if(Input.GetKeyDown(KeyCode.Escape)){
                MenuPause();
            }
        }
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

    public void MenuPause(){
        Menu.SetActive(true);
        settingMenu.SetActive(false);
    }
}
