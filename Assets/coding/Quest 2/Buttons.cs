using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private Image buttons;
    [SerializeField] private Color buttonActiveColor;
    [SerializeField] private Color buttonDisableColor;

    private void Start(){
        buttonActiveColor.a = 1;
        buttonDisableColor.a = 1;
    }

    private void Update(){
        
    }

    public void buttonColorChange(bool button){
        if(button == true){
            buttons.color = buttonActiveColor;
        }
        else if(button == false){
            buttons.color = buttonDisableColor;
        }
    }
}
