using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightControl : MonoBehaviour
{

    public GameObject lighting;

    void Update()
    {
        if(PlayerControler.lightSet == true){
            lighting.SetActive(true);
        }
        else if(PlayerControler.lightSet == false){
            lighting.SetActive(false);
        }
    }
}
