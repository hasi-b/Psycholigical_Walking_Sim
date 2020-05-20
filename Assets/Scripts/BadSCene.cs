using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadSCene : MonoBehaviour
{



    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;



    IEnumerator endscene()
    {

        yield return new WaitForSeconds(3f);
        
        text1.SetActive(true);

        yield return new WaitForSeconds(5f);
        Destroy(text1);
        text2.SetActive(true);

        yield return new WaitForSeconds(5f);
        Destroy(text2);
        text3.SetActive(true);

        yield return new WaitForSeconds(10f);
        Destroy(text3);
        text4.SetActive(true);

        yield return new WaitForSeconds(5f);
        Destroy(text4);
        text5.SetActive(true);

        yield return new WaitForSeconds(5f);
        Destroy(text5);
        text6.SetActive(true);
        yield return new WaitForSeconds(7f);
        Debug.Log("Done");
        Application.Quit();


    }

    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        StartCoroutine(endscene());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
