using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVChange : MonoBehaviour
{

    public Camera myCam;
    float nextFOV =60f;
    public float check = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myCam = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check == 1)
        {
            myCam.fieldOfView = nextFOV ;
        }
    }
}
