using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public DialogueTrigger trigger;
    private const float detectRadius = 0.5f;
    public LayerMask detectLayer;

    public GameObject Dialogue;

    void Update(){
        if(IsDetected() && Input.GetKeyDown(KeyCode.E)){
            Dialogue.SetActive(true);
            trigger.StartDialogue();
        }
    }

    bool IsDetected(){
        return Physics2D.OverlapCircle(transform.position, detectRadius, detectLayer);
    }
}
