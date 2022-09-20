using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundControl : MonoBehaviour
{

    public GameObject lights;
    public GameObject lightOut;

    void Update()
    {
        if(PlayerControler.lightSet == true){
            lights.SetActive(true);
            lightOut.SetActive(false);
        }
        else if(PlayerControler.lightSet == false){
            lights.SetActive(false);
            lightOut.SetActive(true);
        }
    }
}
