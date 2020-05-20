using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    AudioSource audio1;
    AudioSource audio2;

    private void Start()
    {
        audio1 = GameObject.FindGameObjectWithTag("ND").GetComponent<AudioSource>();
        audio2 = GameObject.FindGameObjectWithTag("ND2").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void Resume()
    {
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        audio2.Play();
    }

    void pause()
    {
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        audio1.Play();
    }
    public void Loadmenu()
    {
        Time.timeScale = 1f;
        audio2.Play();
        
        SceneManager.LoadScene("MainMenus");
        Debug.Log("LM");
    }
    public void QuitGame()
    {
        audio2.Play();
        Application.Quit();
        Debug.Log("QM");
    }
}
