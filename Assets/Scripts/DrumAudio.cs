using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumAudio : MonoBehaviour
{
    DrumInputSystem dis;
    public string[] audioID;

    // Start is called before the first frame update
    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
        dis.anythingInput.AddListener(PlayDrumAudio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayDrumAudio(DrumInput d) {
        AudioFW.Play(audioID[(int)d]);
        print("Played " + d);
    }
}
