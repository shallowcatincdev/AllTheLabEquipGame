using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty; //empty variable (will enter dialogue through inspector)
        StartDialogue();
    }//end start

    // Update is called once per frame
    void Update()
    {
        
    }//end update

    //starts the first piece of dialogue
    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }//end StartDialogue

    //method to progress dialogue
    void PlayLines()
    {
        //if the last char shown is equal to the last char in lines[], then switch lines
        if (textComponent.text == lines[index])
        {
            NextLine();
        }//end if
        else
        {
            //end everything
            StopAllCoroutines();
            textComponent.text = lines[index]; //shows all the chars and completes the dialogue
        }//end else
    }//end PlayLines

    //plays the lines out
    IEnumerator TypeLine()
    {
        //turns string into char and plays out each char value at a set speed
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }//end foreach
    }//end TypeLine

    void NextLine()
    {
        //switches to the next string value in the array 
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty; //empty variable (will enter dialogue through inspector)
            StartCoroutine(TypeLine());
        }//end if 
        else
        {
            gameObject.SetActive(false);
        }//end else
    }//end NextLine
}//end class
