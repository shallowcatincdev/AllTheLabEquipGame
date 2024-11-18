using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogNext : MonoBehaviour
{
    [SerializeField] Dialog dialog;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dialog.Next();
        }
    }
}
