using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2 : MonoBehaviour
{

    [SerializeField] private Image Wire1;
    [SerializeField] private Image Wire2;
    [SerializeField] private Image Wire3;
    [SerializeField] private Image Wire4;
    [SerializeField] private Image Wire5;
    [SerializeField] private Image Wire6;
    [SerializeField] private Image Wire7;

    [SerializeField] private Color WireActiveColor1;
    [SerializeField] private Color WireActiveColor2;
    [SerializeField] private Color WireActiveColor3;
    [SerializeField] private Color WireActiveColor4;
    [SerializeField] private Color WireActiveColor5;
    [SerializeField] private Color WireActiveColor6;
    [SerializeField] private Color WireActiveColor7;

    [SerializeField] private Color WireDisableColor1;
    [SerializeField] private Color WireDisableColor2;
    [SerializeField] private Color WireDisableColor3;
    [SerializeField] private Color WireDisableColor4;
    [SerializeField] private Color WireDisableColor5;
    [SerializeField] private Color WireDisableColor6;
    [SerializeField] private Color WireDisableColor7;

    public GameObject Mathematic;
    public GameObject MathematicOff;
    public GameObject Floor2;

    List<string> Button = new List<string>();

    private void Start(){
        WireActiveColor1.a = 1;
        WireDisableColor1.a = 1;

    }

    void Update(){
        if(Button.Contains("1") == true && Button.Contains("2") == true){           //Wire 1
            Wire1.color = WireActiveColor1;
        }
        else if(Button.Contains("1") == false || Button.Contains("2") == false){
            Wire1.color = WireDisableColor1;
        }

        if(Button.Contains("2") == true && Button.Contains("3") == true){           //Wire 2
            Wire2.color = WireActiveColor2;
        }
        else if(Button.Contains("2") == false || Button.Contains("3") == false){
            Wire2.color = WireDisableColor2;
        }

        if(Button.Contains("3") == true && Button.Contains("4") == true){           //Wire 3
            Wire3.color = WireActiveColor3;
        }
        else if(Button.Contains("3") == false || Button.Contains("4") == false){
            Wire3.color = WireDisableColor3;
        }

        if(Button.Contains("4") == true && Button.Contains("5") == true){           //Wire 4
            Wire4.color = WireActiveColor4;
        }
        else if(Button.Contains("4") == false || Button.Contains("5") == false){
            Wire4.color = WireDisableColor4;
        }

        if(Button.Contains("5") == true && Button.Contains("6") == true){           //Wire 5
            Wire5.color = WireActiveColor5;
        }
        else if(Button.Contains("5") == false || Button.Contains("6") == false){
            Wire5.color = WireDisableColor5;
        }

        if(Button.Contains("2") == true && Button.Contains("6") == true){           //Wire 6
            Wire6.color = WireActiveColor6;
        }
        else if(Button.Contains("2") == false || Button.Contains("6") == false){
            Wire6.color = WireDisableColor6;
        }

        if(Button.Contains("1") == true && Button.Contains("4") == true){           //Wire 7
            Wire7.color = WireActiveColor7;
        }
        else if(Button.Contains("1") == false || Button.Contains("4") == false){
            Wire7.color = WireDisableColor7;
        }

        if(Button.Contains("1") && Button.Contains("2") && Button.Contains("3") && Button.Contains("4") && Button.Contains("5") && Button.Contains("6")){
            Quest2.MiniGame = false;
            Quest2.mathClear = true;
            Time.timeScale = 1f;
            Quest2.MiniGame = false;
            PlayerControler.lightSet = true;
            MathematicOff.SetActive(false);
            Mathematic.SetActive(true);
            Floor2.SetActive(false);
        }

    }

    public void Button1Active(bool button){
        if(button == true){
            Button.Add("1");
        }
        else if(button == false){
            Button.Remove("1");
        }
    }

    public void Button2Active(bool button){
        if(button == true){
            Button.Add("2");
        }
        else if(button == false){
            Button.Remove("2");
        }
    }
    
    public void Button3Active(bool button){
        if(button == true){
            Button.Add("3");
        }
        else if(button == false){
            Button.Remove("3");
        }
    }

    public void Button4Active(bool button){
        if(button == true){
            Button.Add("4");
        }
        else if(button == false){
            Button.Remove("4");
        }
    }

    public void Button5Active(bool button){
        if(button == true){
            Button.Add("5");
        }
        else if(button == false){
            Button.Remove("5");
        }
    }

    public void Button6Active(bool button){
        if(button == true){
            Button.Add("6");
        }
        else if(button == false){
            Button.Remove("6");
        }
    }
}
