using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOffTrigger : MonoBehaviour, IDataPersistence
{
    [SerializeField] private string id;

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid(){
        id = System.Guid.NewGuid().ToString();
    }

    public static bool HadActive = false;

    public void SaveData(GameData data){
        if(data.lightOffTrigger.ContainsKey(id)){
            data.lightOffTrigger.Remove(id);
        }
        data.lightOffTrigger.Add(id, HadActive);
    }

    public void LoadData(GameData data){
        data.lightOffTrigger.TryGetValue(id, out HadActive);
        if(HadActive == true){
            Destroy(this);
        }
    }

    public void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
            PlayerControler.lightSet = false;
            Destroy(this);
        }
    }

    
}
