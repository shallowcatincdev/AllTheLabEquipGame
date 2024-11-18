using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public void OnContinue()
    {
        SceneManager.LoadScene(1);
    }
}
