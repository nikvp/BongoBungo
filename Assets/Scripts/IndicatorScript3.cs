using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript3 : MonoBehaviour
{
    DrumInputSystem dis;
    public Color origColor;
    public Color pressedColor;
    //public bool beingPressed;
    //float presstime = 0.2f;
    //public DrumInput pressedDrum;
    void Awake() {
        dis = FindObjectOfType<DrumInputSystem>();
        dis.D3Single.AddListener(DrumWasPlayed);
        dis.D3Double.AddListener(DrumWasPlayed);
        dis.D3Triple.AddListener(DrumWasPlayed);
    }

    private void Update() {
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
        //beingPressed = true;
        //pressedDrum = drum;
        print("Played" + drum);
    }
}
