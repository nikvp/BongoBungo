using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatIndicatorScriptD3 : MonoBehaviour
{
    public bool canBePressed;
    DrumInputSystem dis;
    public bool singlePressed;
    public bool doublePressed;
    public bool triplePressed;
    public bool needed1Pressed;
    public bool needed2Pressed;
    public bool needed3Pressed;
    public bool correctlyPressed;

    private void Awake() {
        dis = FindObjectOfType<DrumInputSystem>();
        dis.D3Single.AddListener(PressButton);
        dis.D3Double.AddListener(PressButton);
        dis.D3Triple.AddListener(PressButton);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Activator3") {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Activator3") {
            canBePressed = false;
        }
    }

    void CorrectlyPressed() {
        if (needed1Pressed == true && singlePressed == true) {
            correctlyPressed = true;
        } else if (needed2Pressed == true && doublePressed == true) {
            correctlyPressed = true;
        } else if (needed3Pressed == true && triplePressed == true) {
            correctlyPressed = true;
        } else correctlyPressed = false;
    }



    void PressButton(DrumInput d) {
        if (d == DrumInput.D3Single) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                singlePressed = true;
                CorrectlyPressed();
                if (canBePressed == true && correctlyPressed == true) {
                    Destroy(gameObject);
                }
            }
            singlePressed = false;

        } else if (d == DrumInput.D3Double) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                doublePressed = true;
                CorrectlyPressed();
                if (canBePressed == true && correctlyPressed == true) {
                    Destroy(gameObject);
                }
            }
            doublePressed = false;
        } else if (d == DrumInput.D3Triple) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                triplePressed = true;
                CorrectlyPressed();
                if (canBePressed == true && correctlyPressed == true) {
                    Destroy(gameObject);
                }
            }
            triplePressed = false;
        }
    }
}
