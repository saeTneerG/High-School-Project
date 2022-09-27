using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterPass : MonoBehaviour
{
    public GameObject beforeClear;
    public GameObject afterClear;

    void Update()
    {
        if(Quest1.ChemClear == true){
            afterClear.SetActive(true);
            beforeClear.SetActive(false);
        }
    }
}
