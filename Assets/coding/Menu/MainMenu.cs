using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Menu Buttons")]
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button LoadGameButton;

    public GameObject MainMenuUI;
    public GameObject SettingUI;
    public GameObject SaveLoad;

    private void Start(){
        if(!DataPersistenceManagement.instance.gameDataCheck()){
            LoadGameButton.interactable = true;
        }
    }

    public void StartGame(){
        MainMenuUI.SetActive(false);
        SaveLoad.SetActive(true);
    }

    public void SettingMenu(){
        PauseMenu.settingIsActive = true;
        MainMenuUI.SetActive(false);
        SettingUI.SetActive(true);
    }

    public void ExitGame(){
        Debug.Log("Exiting...");
        Application.Quit();
    }

    public void OnNewGame(){
        DataPersistenceManagement.instance.NewGame();
        SceneManager.LoadSceneAsync(1);
    }

    public void OnLoadGame(){
        DataPersistenceManagement.instance.SaveGame();
        SceneManager.LoadSceneAsync(1);
    }
}
