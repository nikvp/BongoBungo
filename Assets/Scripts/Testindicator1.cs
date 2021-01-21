using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testindicator1 : MonoBehaviour {
    // Start is called before the first frame update
    public bool singlePressed;
    public bool doublePressed;
    public bool triplePressed;
    public bool needed1Pressed;
    
    DrumInputSystem dis;

    void Awake() {

        dis = FindObjectOfType<DrumInputSystem>();
        dis.D1Single.AddListener(PressButton);
        dis.D1Double.AddListener(PressButton);
        dis.D1Triple.AddListener(PressButton);
    }

    // Update is called once per frame

    void PressButton(DrumInput d) {
        if (d == DrumInput.D1Single) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                singlePressed = true;
            }
            singlePressed = false;

        } else if (d == DrumInput.D1Double) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                doublePressed = true;
            }
            doublePressed = false;
        } else if (d == DrumInput.D1Triple) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                triplePressed = true;
            }
            triplePressed = false;
        }
    }
}
