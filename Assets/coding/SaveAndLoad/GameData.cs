using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GameData
{
    public Vector3 PlayerPos;
    public bool lights;
    public bool math;
    public bool chem;
    public bool bio;
    public Transform camTarget;

    public int Scening;

    public Dictionary<string, bool> lightOffTrigger;

    public GameData(){
        Scening = 1;
        PlayerPos = new Vector3(20.26f, -1.83f, 0f);
        lightOffTrigger = new Dictionary<string, bool>();
        lights = true;
        math = false;
        chem = false;
        bio = false;
    }
}
