using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    AudioSource audio1;

    // Start is called before the first frame update
    private void Start()
    {
        audio1 = GameObject.FindGameObjectWithTag("ND").GetComponent<AudioSource>();
    }

    public void play()
    {
        audio1.Play();
        SceneManager.LoadScene("Main Level");

    }
    public void Quit()
    {
        audio1.Play();
        Debug.Log("gese");
        Application.Quit();
    }
}
