using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue Npc;
    // Canvas.GetComponent<Dialogue>().Dialogue; 

    public void TriggerDialogue()
    {

        FindObjectOfType<DialogueManager>().StartDialogue(Npc);
    
    }
}
 