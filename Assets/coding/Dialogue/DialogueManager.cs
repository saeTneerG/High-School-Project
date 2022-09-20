using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text actorName;
    public Text messageText;    

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;

    public GameObject Dialogues;

    public void OpenDialogue(Message[] messages, Actor[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        Debug.Log("Start Conversation..." + messages.Length);
        DisplayMessage();
    }

    void DisplayMessage(){
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorID];
        actorName.text = actorToDisplay.name;

        AnimateTextColor();
    }

    public void NextMessage(){
        activeMessage++;
        if(activeMessage < currentMessages.Length){
            DisplayMessage();
        }
        else {
            Debug.Log("Conversation End.");
            isActive = false;
            Dialogues.SetActive(false);
        }
    }

    void AnimateTextColor(){
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isActive == true){
            NextMessage();
        }
    }
}
