using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystemContorl : MonoBehaviour
{
    public GameObject[] eventSystems;

    void Start()
    {
        eventSystems = GameObject.FindGameObjectsWithTag("EventSystems");
    }

    void Update()
    {
        if(eventSystems.Length > 1){
            Destroy(eventSystems[1]);
        }
    }
}
