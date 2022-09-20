using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1 : MonoBehaviour
{
    public int x = 0;
    public static bool ChemClear = false;

    public GameObject[] QuestItem;

    void Start(){
        QuestItem = GameObject.FindGameObjectsWithTag("QuestItem");
    }

    void Update(){
        if(QuestItem.Length > 5){
            Destroy(QuestItem[5]);
        }
    }

    public void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "QuestItem"){
            x++;
            Debug.Log(x);
            Destroy(col.gameObject);

            if(x == 5){
                ChemClear = true;
            }
        }
    }
}
