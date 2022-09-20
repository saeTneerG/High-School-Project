using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLoop : MonoBehaviour
{

    public static bool x1 = false;
    public static bool x2 = false;
    public static bool x3 = false;

    void Update(){
        if(x1 == true && x2 == true && x3 == true){
            Door.canGo = true;
        }
    }
}
