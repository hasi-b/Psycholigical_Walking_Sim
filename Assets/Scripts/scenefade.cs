using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenefade : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float check = 0f;
    public float check2 = 0f;
    // Update is called once per frame
    void Update()
    {
        if (check == 1f)
        {
            Debug.Log("KOK");
            animator.SetTrigger("Fadeout");
        }

    }
    public void aevent()
    {
        check2 = 1f;
    }
   
}
