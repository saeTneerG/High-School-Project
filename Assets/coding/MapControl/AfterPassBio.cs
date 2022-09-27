using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterPassBio : MonoBehaviour
{
    public GameObject beforeClear;
    public GameObject afterClear;

    void Update()
    {
        if(Bio.BioClear == true){
            afterClear.SetActive(true);
            beforeClear.SetActive(false);
        }
    }
}
