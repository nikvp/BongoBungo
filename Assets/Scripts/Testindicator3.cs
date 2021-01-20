using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testindicator3 : MonoBehaviour
{
    public bool singlePressed;
    public bool doublePressed;
    public bool triplePressed;
    //public Color origColor;
    //public Color pressedColor;
    SpriteRenderer spr;

    void Awake() {
        spr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        if (singlePressed == true) {
            for (float i = 0; i < 0.2f; i += Time.deltaTime) {
                spr.color = Color.red;
            }
        } else if (doublePressed == true) {
            for (float i = 0; i < 0.2f; i += Time.deltaTime) {
                spr.color = Color.green;
            }
        } else if (triplePressed == true) {
            for (float i = 0; i < 0.2f; i += Time.deltaTime) {
                spr.color = Color.blue;
            }
        }
    }


}
