using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightCharactorControl : MonoBehaviour
{

    public GameObject lightings;

    void Update()
    {
        if(PlayerControler.lightSet == true){
            lightings.SetActive(false);
        }
        else if(PlayerControler.lightSet == false){
            lightings.SetActive(true);
        }
    }
}
