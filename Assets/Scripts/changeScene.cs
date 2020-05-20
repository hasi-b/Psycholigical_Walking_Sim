using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    triggerDetectionFirstLevel tg;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Scene", 0);
        tg = GameObject.FindGameObjectWithTag("cube").GetComponent<triggerDetectionFirstLevel>();
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (tg.check == 1f)
        {
            
            Debug.Log("CHEEECk");
           
                SceneManager.LoadScene("Second Scene");
            
            
        }
    }
}
