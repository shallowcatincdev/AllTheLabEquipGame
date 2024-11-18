using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    [SerializeField] TextMeshPro text;
    int line;
    string[] lines = {"Yo i'm drake, take me down the street to da CN Tower. Make it quick and a nice tip going your way", "", "Yo! Up here on the left just pull over"};
    public void Next()
    {
        line++;
    }

    private void Update()
    {
        text.text = lines[line];
    }
}
