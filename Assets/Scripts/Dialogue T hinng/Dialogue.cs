using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{
    //initializing variables
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;
    private bool startedDial;

    public float timer;
    public float startingTime;

    [SerializeField] private bool blartingGime;


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty; //empty variable (will enter dialogue through inspector)
        //StartDialogue();
        startedDial = false;

        timer = startingTime;
        blartingGime = false;
    }//end start

    //ACTUALLY starts the dialogue
    public void StartBlartingGime()
    {
        //plays the first bit of dialogue and subsequent uses of this method will play the rest of the dialogue
        //a good portion of this is if the player wants to manually skip dialogue
        if (startedDial == false)
        {
            StartDialogue();
            startedDial = true;
            
        }//end if
        else
        {
   
            PlayLines(); 
        }//end else

        blartingGime = true;
        timer = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        //automatic dialogue
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            //Debug.Log("gooning"); //tracing
            //resetting the timer
            timer = startingTime;

            if (blartingGime == true) //starts reading out the lines after starting dialogue
            {
                //stopping coroutines (dialogue) and playing the next thingy
                StopAllCoroutines();
                NextLine();
            }//end if
            else
            {
                Debug.Log("no dialogue");
            }//end else
            
        }//end if

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
