using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depawn : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider colission)
    {
        if (colission.gameObject.tag == "Despawn")
        {
            Destroy(this);
        }
    }

    

}
