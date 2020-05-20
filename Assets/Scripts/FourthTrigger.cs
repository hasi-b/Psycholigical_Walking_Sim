using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FourthTrigger : MonoBehaviour
{
    public GameObject firstobstacle;
    public GameObject firstobstacleD;
    public GameObject collidor;
    public GameObject text;
    public GameObject sun;
    public GameObject sunD;
    public GameObject Door;
    public GameObject collidor2;
    public GameObject SecondObstacle;
    public GameObject FinalDoor;
    public int check;
    
    // Start is called before the first frame update
    void Start()
    {
        check = PlayerPrefs.GetInt("Scene");
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collidor")
        {
            firstobstacleD = (GameObject)Instantiate(firstobstacle, new Vector3(-2.013097f, 0.6932545f, -10.1652f), Quaternion.Euler(0f,0f,0f));
            Destroy(collidor);
        }
        if(other.tag == "cube")
        {
            sunD = (GameObject)Instantiate(sun, new Vector3(-0.14f,1.49f,4.4f), Quaternion.Euler(0f,0f,0f));
           
            Destroy(collidor2);
        }
        if (other.tag == "Door" && check == 1)
        {
            SceneManager.LoadScene("ThirdScene");
        }
        if(other.tag == "Door"&& check ==2)
        {
            SceneManager.LoadScene("FifthScene");
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "dc" && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(text, new Vector3(-0.07f, 1.86387f, -8.79f),Quaternion.Euler(0f,0f,0f));
            Destroy(firstobstacleD);
        }
        if(other.tag == "sun" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("lo");
            Destroy(sunD);
            Destroy(Door);
        }

        if (other.tag == "red" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(SecondObstacle);
            Instantiate(FinalDoor, new Vector3(-34.24f, 0.26f, 4.02f), Quaternion.Euler(-90f, 90f, 0f));
            
        }
     

    }
}
