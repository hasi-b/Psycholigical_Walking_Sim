using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class asylumTrigger : MonoBehaviour
{
    public GameObject vincent;
    public GameObject Earnest;
    public GameObject vincentD;
    public GameObject EarnestD;
    public GameObject trigger2;
    public GameObject trigger2D;
    public GameObject trigger1;
    public GameObject Bed;
    public GameObject door;
    public GameObject teddy;
    public GameObject anotherdoor;
    public int check;
    TextMeshPro tmp;
    public Vector3 vincen= new Vector3(-14.695f, 2.02857f, 2.472f);
    public Vector3 earnie = new Vector3(-6.66f,1.96f,2.486f);
    public Vector3 trig = new Vector3(-22.3f, 0.4f, 1.4f);
    // Start is called before the first frame update

    private void Start()
    {
        tmp = GameObject.FindGameObjectWithTag("text").GetComponent<TextMeshPro>();
        check = PlayerPrefs.GetInt("Scene");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collidor")
        {
            Instantiate(Earnest, earnie, Quaternion.Euler(0f,0f,0f));
            Destroy(EarnestD);
        }
        if (other.tag == "anothercollidor")
        {
            Instantiate(vincent, vincen, Quaternion.Euler(0f, 0f, 0f));
            Destroy(vincentD);
        }
        if(other.tag == "col1")
        {
           
            trigger2D= (GameObject) Instantiate(trigger2, new Vector3(-22.01f,0.89f,0.63f), Quaternion.Euler(0f,180f,0f));
            Destroy(trigger1);
            tmp.SetText("It is all inside your Head");
        }
        if (other.tag == "col3")
        {
            Instantiate(anotherdoor, new Vector3(-14.39f, 0.42f, -2.18f), Quaternion.Euler(-90f, -24.53f, 24.53f));
            Destroy(teddy);
            Destroy(door);
            Destroy(trigger2D);
            Destroy(Bed);

        }
        if (other.tag == "dc" && check==2)
        {
            SceneManager.LoadScene("FourthScene");
        }
        if (other.tag == "dc" && check == 1)
        {
            SceneManager.LoadScene("FifthScene");
        }
    }
}
