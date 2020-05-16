using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFlicker : MonoBehaviour
{
    public float timeDelay;
    public bool isFlickering = false;
    public Light pointlight;
   
  

    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(Flickeringlight());
        }
    }
    IEnumerator Flickeringlight()
    {
        isFlickering = true;
       
        pointlight.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f,1.1f);
        yield return new WaitForSeconds(timeDelay);
       
        pointlight.gameObject.GetComponent<Light>().enabled = true;
       
        timeDelay = Random.Range(0.01f, 1.1f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}
