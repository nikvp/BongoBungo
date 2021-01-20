using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    DrumInputSystem dis;
    public Color origColor;
    public Color pressedColor;
    //public bool beingPressed;
    //float presstime = 0.2f;
    //public DrumInput pressedDrum;
    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
        dis.D1Single.AddListener(DrumWasPlayed);
        dis.D1Double.AddListener(DrumWasPlayed);
        dis.D1Triple.AddListener(DrumWasPlayed);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DrumWasPlayed(DrumInput drum) {

        print("Played" + drum);
    }
}
