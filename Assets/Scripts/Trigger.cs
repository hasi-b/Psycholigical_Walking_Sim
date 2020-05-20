using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public GameObject clock;
    public GameObject Piano;
    public GameObject PianoD;
    public GameObject trigger;
    public GameObject trigger2;
    public GameObject triggers2;
    public GameObject Radio;
    public GameObject RadioD;
    public GameObject leftTrig;
    public GameObject leftTrigD;
    public GameObject rightTrig;
    public GameObject rightTrigD;
    public GameObject thirdText;
    public GameObject fourthText;
    public GameObject fifthText;
    public GameObject redDoor;
    public GameObject blueDoor;
    public Vector3 redeDoor = new Vector3(-15.9f,0f,-23.2f);
    public Vector3 blueeDoor = new Vector3(16.79f,0f,-23.23f);
    public Vector3 collidor3 = new Vector3(16f, 0.44f, -0.7f);
    public Vector3 collidor4 = new Vector3(-16f, 0.44f, 3.9f);
    public Vector3 quote1 = new Vector3(-0.91f, 9.85f, -23.55f);
    public Vector3 quote2 = new Vector3(-24.09f, 12.38f, -1.34f);
    public Vector3 quote31 = new Vector3(24.2f, 9.85f, -0.6f);
    public float check = 0f;
    public float counter=0;
    public float finalcheck = 0f;
    alternates al;
    SpawnFirstText sT;
    Vector3 pPosition = new Vector3(-0.92f, 1.32f, 19.74f);  //position of the piano to spawn
  
    // Start is called before the first frame update
   
   IEnumerator Appear()
    {
        yield return new WaitForSeconds(30f);
    }
    void Start()
    {
        sT = GameObject.FindGameObjectWithTag("Respawn").GetComponent<SpawnFirstText>();
       

        startcor();
    }

    public void startcor()
    {
        if(finalcheck == 3)
        {
            StartCoroutine(Appear());
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(finalcheck == 3)
        {
            finalcheck = 100f;
           
            Instantiate(redDoor,blueeDoor,Quaternion.Euler(-90f,-24.53f,24.53f));
            Instantiate(blueDoor, redeDoor, Quaternion.Euler(-90f,-24.53f,24.53f));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collidor" && counter ==0f)// if the collidor is the box collidor that player touches then execute
        {
            
            Destroy(sT.triggerDestroy);
            Destroy(clock);
            PianoD = (GameObject) Instantiate(Piano, pPosition, Quaternion.Euler(0f,270f,0f));//spawn the piano
            triggers2=(GameObject) Instantiate(trigger2, pPosition, Quaternion.Euler(0f, 0f, 0f));
            Debug.Log("Checked");
            counter = 1f;
        }
        if(other.tag == "anothercollidor" && counter == 1f)
        {
            Destroy(sT.firstTexts);
            Destroy(triggers2);
            check = 1f;
            counter = 2f;
        }
        if (other.tag == "collidor" && counter == 2f)// if the collidor is the box collidor that player touches then execute
        {

            Destroy(sT.triggerDestroy);
            Destroy(PianoD);
            RadioD = (GameObject)Instantiate(Radio, pPosition, Quaternion.Euler(0f, 180f, 0f));//spawn the piano
            triggers2 = (GameObject)Instantiate(trigger2, pPosition, Quaternion.Euler(0f, 0f, 0f));
            
            Debug.Log("Checked");
            counter = 3f;
        }
        if (other.tag == "anothercollidor" && counter == 3f)
        {
            Debug.Log("LEGESE");
            Destroy(sT.secondTexts);
            Destroy(triggers2);
            sT.trigDestroy();
            leftTrigD = (GameObject)Instantiate(leftTrig,collidor3,Quaternion.Euler(0f,90f,0f));
            rightTrigD = (GameObject)Instantiate(rightTrig,collidor4, Quaternion.Euler(0f, 90f, 0f));
            Instantiate(thirdText, quote1, Quaternion.Euler(0f,180f,0f));
            Instantiate(fourthText, quote2, Quaternion.Euler(0f, 270f, 0f));
            Instantiate(fifthText, quote31, Quaternion.Euler(0f, 90f, 0f));
            counter = 4f;
        }
        if(other.tag == "collidor" && counter ==4f)
        {
            Destroy(sT.triggerDestroy);
            finalcheck++;
        }
        if (other.tag == "right")
        {
            Destroy(rightTrigD);
            finalcheck++;
        }
        if (other.tag == "left")
        {
            Destroy(leftTrigD);
            finalcheck++;
        }
        if(other.tag == "red" )
        {
            PlayerPrefs.SetInt("Scene", 2);
            SceneManager.LoadScene("ThirdScene");
        }
        if(other.tag == "blue" )
        {
            PlayerPrefs.SetInt("Scene", 1);
            SceneManager.LoadScene("FourthScene");
            
        }

    }
   public void spawnTriggeragain()
    {
        triggers2 = (GameObject)Instantiate(trigger2, pPosition, transform.rotation);
    }
    
}
