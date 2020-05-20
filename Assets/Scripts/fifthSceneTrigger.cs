using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class fifthSceneTrigger : MonoBehaviour
{

    public GameObject[] collidor = new GameObject[6];
    public GameObject[] floor = new GameObject[5];
    public GameObject firstRoom;
    public GameObject door;
    public TextMeshPro tm;
    public TextMeshPro tm1;
    public GameObject Roomdestroy;
    public GameObject SecondRoom;
    public TextMeshPro dtxt;
    public TextMeshPro utxt;
    public GameObject ltext;
    public GameObject rtext;
    public GameObject DOOR;
    


    FOVChange fv;





    AudioSource audio;
    // Start is called before the first frame update

        IEnumerator text()
    {

        yield return new WaitForSeconds(30f);
        dtxt.SetText("Now Be The Breach\nPress 'E'");

    }
        IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(30f);
        tm.SetText("Dont Enter \n You Wont like it");
        tm1.SetText("The Game is Already \n Rigged");
        audio.Play();
        Destroy(door);
    }
    void Start()
    {
        
        
        audio = GameObject.FindGameObjectWithTag("ad").GetComponent<AudioSource>();
        fv = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<FOVChange>();
        for(int i = 0; i < 5; i++)
        {
            floor[i].SetActive(false);
        }
        firstRoom.SetActive(false);
        SecondRoom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "lcol1")
        {
            floor[0].SetActive(true);
            audio.Play();
            Destroy(collidor[0]);
        }
        if (other.tag == "lcol2")
        {
            floor[1].SetActive(true);
            audio.Play();
            Destroy(collidor[1]);
        }
        if (other.tag == "lcol3")
        {
            floor[2].SetActive(true);
            audio.Play();
            Destroy(collidor[2]);
        }
        if (other.tag == "lcol4")
        {
            floor[3].SetActive(true);
            audio.Play();
            Destroy(collidor[3]);
        }
        if (other.tag == "lcol5")
        {
            floor[4].SetActive(true);
            audio.Play();
            Destroy(collidor[4]);
        }
        if (other.tag == "lcol6")
        {

            audio.Play();
            fv.check = 1;
           
            Destroy(collidor[5]);
            firstRoom.SetActive(true);
            StartCoroutine((Wait()));
        }
        if(other.tag == "newcol1")
        {

            audio.Play();
            Destroy(Roomdestroy);
            SecondRoom.SetActive(true);
            StartCoroutine(text());
        }
        if(other.tag == "dc")
        {
            SceneManager.LoadScene("LastScene");
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "blue" && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(DOOR,new Vector3(10.89f,1.21f,141.47f) ,Quaternion.Euler(-90f,-24.53f,24.53f));
            utxt.SetText("You Have Seen Enough\n It's Time To End");
            Destroy(ltext);
            Destroy(rtext);
        }
    }
}
