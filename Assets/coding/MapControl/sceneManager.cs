using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager : MonoBehaviour
{
    public GameObject floor1;//1
    public GameObject floor2;//2
    public GameObject floor3;//3
    public GameObject Mathematic;//4
    public GameObject Chemical;//5
    public GameObject Biological;//6
    public GameObject Physic;//7
    public GameObject English;//8

    public GameObject floor1Off;
    public GameObject floor2Off;
    public GameObject floor3Off;
    public GameObject MathematicOff;

    public int ChangeSceneTo;
    public Transform Player;
    public Transform Position;

    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    void Update()
    {
        if(IsDetected() && Input.GetKeyDown(KeyCode.E)){
            Debug.Log("Track");
            if(ChangeSceneTo == 1 && PlayerControler.lightSet == true){
                floor1.SetActive(true);
                floor2.SetActive(false);
                floor3.SetActive(false);
                Mathematic.SetActive(false);
                Chemical.SetActive(false);
                Biological.SetActive(false);
                Physic.SetActive(false);
                English.SetActive(false);
            }
            if(ChangeSceneTo == 1 && PlayerControler.lightSet == false){
                floor1Off.SetActive(true);
                floor2Off.SetActive(false);
                floor3Off.SetActive(false);
                MathematicOff.SetActive(false);
            }

            if(ChangeSceneTo == 2 && PlayerControler.lightSet == true){
                floor1.SetActive(false);
                floor2.SetActive(true);
                floor3.SetActive(false);
                Mathematic.SetActive(false);
                Chemical.SetActive(false);
                Biological.SetActive(false);
                Physic.SetActive(false);
                English.SetActive(false);
            }
            if(ChangeSceneTo == 2 && PlayerControler.lightSet == false){
                floor1Off.SetActive(false);
                floor2Off.SetActive(true);
                floor3Off.SetActive(false);
                MathematicOff.SetActive(false);
            }

            if(ChangeSceneTo == 3 && PlayerControler.lightSet == true){
                floor1.SetActive(false);
                floor2.SetActive(false);
                floor3.SetActive(true);
                Mathematic.SetActive(false);
                Chemical.SetActive(false);
                Biological.SetActive(false);
                Physic.SetActive(false);
                English.SetActive(false);
            }
            if(ChangeSceneTo == 3 && PlayerControler.lightSet == false){
                floor1Off.SetActive(false);
                floor2Off.SetActive(false);
                floor3Off.SetActive(true);
                MathematicOff.SetActive(false);
            }

            if(ChangeSceneTo == 4 && PlayerControler.lightSet == true){
                floor1.SetActive(false);
                floor2.SetActive(false);
                floor3.SetActive(false);
                Mathematic.SetActive(true);
                Chemical.SetActive(false);
                Biological.SetActive(false);
                Physic.SetActive(false);
                English.SetActive(false);
                Player.position = Position.position;
            }
            if(ChangeSceneTo == 4 && PlayerControler.lightSet == false){
                floor1Off.SetActive(false);
                floor2Off.SetActive(false);
                floor3Off.SetActive(false);
                MathematicOff.SetActive(true);
                Player.position = Position.position;
            }

            if(ChangeSceneTo == 5 && PlayerControler.lightSet == true){
                floor1.SetActive(false);
                floor2.SetActive(false);
                floor3.SetActive(false);
                Mathematic.SetActive(false);
                Chemical.SetActive(true);
                Biological.SetActive(false);
                Physic.SetActive(false);
                English.SetActive(false);
                Player.position = Position.position;
            }

            if(ChangeSceneTo == 6 && PlayerControler.lightSet == true){
                floor1.SetActive(false);
                floor2.SetActive(false);
                floor3.SetActive(false);
                Mathematic.SetActive(false);
                Chemical.SetActive(false);
                Biological.SetActive(true);
                Physic.SetActive(false);
                English.SetActive(false);
                Player.position = Position.position;
            }

            if(ChangeSceneTo == 7 && PlayerControler.lightSet == true){
                floor1.SetActive(false);
                floor2.SetActive(false);
                floor3.SetActive(false);
                Mathematic.SetActive(false);
                Chemical.SetActive(false);
                Biological.SetActive(false);
                Physic.SetActive(true);
                English.SetActive(false);
                Player.position = Position.position;
            }

            if(ChangeSceneTo == 8 && PlayerControler.lightSet == true){
                floor1.SetActive(false);
                floor2.SetActive(false);
                floor3.SetActive(false);
                Mathematic.SetActive(false);
                Chemical.SetActive(false);
                Biological.SetActive(false);
                Physic.SetActive(false);
                English.SetActive(true);
                Player.position = Position.position;
            }
        }
    }

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }

    private void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, detectRadius);
    }

}
