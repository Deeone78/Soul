using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostNo1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue Npc;
    // Canvas.GetComponent<Dialogue>().Dialogue; 
    bool dialogTriggered = false;

    public void TriggerDialogue()
    {
        if (dialogTriggered == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(Npc);
            dialogTriggered = true;
        }
    }
}
