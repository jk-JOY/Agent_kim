using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public void OnclickEvent()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
          
    }
    

}