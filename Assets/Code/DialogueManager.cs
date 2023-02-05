using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Queue<string> sentences;
    public GameObject textBox;
   // public Animator textBox1;
    public Text nameText;
    public Text dialogueText;
    public GameObject Wake;

    void Start()
    {
        sentences = new Queue<string>();
        Wake.SetActive(false);
        // textBox1 = GetComponentInChildren<Animator>();
        textBox.SetActive(false);
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            DisplayNextSentence();
        }
    }



    public void StartDialogue(Dialogue dialogue)
    {
       // textBox1.SetBool("Isopen", true);
        Debug.Log("starting a convertion with" + dialogue.name);
        textBox.SetActive(true);
        nameText.text = dialogue.name;
        
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            DisplayNextSentence();


        }
    }
    public void DisplayNextSentence ()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;


        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        IEnumerator TypeSentence (string sentence)
        {
            dialogueText.text  ="";
            foreach(char letter in sentence.ToCharArray())
            {
                dialogueText.text+= letter;
                yield return new WaitForSeconds(0.05f);

            }
        
        
        
        }
        void EndDialogue()
        {

            textBox.SetActive(false);
            // Debug.Log("End of conversati");
            //  textBox1.SetBool("Isopen", false);
            Wake.SetActive(true);

        }
          
    }
    
    // Update is called once per frame
    
}
