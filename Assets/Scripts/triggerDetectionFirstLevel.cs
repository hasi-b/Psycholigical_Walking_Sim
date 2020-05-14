using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDetectionFirstLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public float check = 0f;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EEEEEEEI");
        if(other.tag == "collidor")
        {
            Debug.Log("Lagsesss");
            check = 1f;
        }
    }
}
