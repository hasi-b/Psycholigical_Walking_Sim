using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finaltrigger : MonoBehaviour
{

    public GameObject rope;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject door;



    AudioSource audio;
    IEnumerator ropess()
    {
        yield return new WaitForSeconds(20f);
        audio.Play();
        rope.SetActive(true);
        yield return new WaitForSeconds(1f);
        audio.Play();
        text1.SetActive(true);
        yield return new WaitForSeconds(1f);
        audio.Play();
        text2.SetActive(true);
        yield return new WaitForSeconds(1f);
        audio.Play();
        text3.SetActive(true);
        yield return new WaitForSeconds(1f);
        audio.Play();
        text4.SetActive(true);
        yield return new WaitForSeconds(1f);
        audio.Play();
        text5.SetActive(true);
        yield return new WaitForSeconds(1f);
        audio.Play();
        text6.SetActive(true);
        yield return new WaitForSeconds(30f);
        door.SetActive(true);

    }
    IEnumerator textspawn()
    {
        yield return new WaitForSeconds(1f);
    }
    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.FindGameObjectWithTag("ad").GetComponent<AudioSource>();
        door.SetActive(false);
        rope.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        StartCoroutine(ropess());

       
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="dc"&& Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("BadScene");
            Debug.Log("sesh");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Door")
        {
            SceneManager.LoadScene("GoodScene");
            Debug.Log("beche gela");
        }
    }
}
