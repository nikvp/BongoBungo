using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTest : MonoBehaviour
{
    public AudioSource myAudio;
    public AudioClip myClip;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            myAudio.PlayOneShot(myClip);
        }
        }
    }

