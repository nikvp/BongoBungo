using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript2 : MonoBehaviour
{
    DrumInputSystem dis;
    public Color origColor;
    public Color pressedColor;
    //public bool beingPressed;
    //float presstime = 0.2f;
    //public DrumInput pressedDrum;
    void Awake() {
        dis = FindObjectOfType<DrumInputSystem>();
        dis.D2Single.AddListener(DrumWasPlayed);
        dis.D2Double.AddListener(DrumWasPlayed);
        dis.D2Triple.AddListener(DrumWasPlayed);

    }


    // Update is called once per frame
    void Update() {
        //if (beingPressed == true) {
        //    presstime -= Time.deltaTime;
        //    if (presstime < 0) {
        //        beingPressed = false;
        //    }
        //} else if (beingPressed == false) {
        //    presstime = 0.2f;
        //}
    }

    void DrumWasPlayed(DrumInput drum) {

        print("Played" + drum);
    }
}
