﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{

    playerMovement PlayerMovement;
    [SerializeField]
    AudioSource audio;
    
    
    // Start is called before the first frame update
    void Start()
    {

        PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        


    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.move.magnitude>0  && audio.isPlaying== false )
        {
            
            audio.volume=Random.Range(0.8f, 1f);
            audio.pitch=Random.Range(0.8f,1.1f);
            audio.Play();
            
        }
    }
}
