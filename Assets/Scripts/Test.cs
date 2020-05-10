using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour

{

    playerMovement PlayerMovement;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
    }

    // Update is called once per frame
  



    private void OnCollisionStay(Collision collision)
    {
        PlayerMovement.isGrounded = true;
    }

}
