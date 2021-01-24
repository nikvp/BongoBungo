using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatIndicatorScriptD1 : MonoBehaviour
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
    ScoreScript script;
    public int beat = 1;
    public bool destroyed;
    GameObject fingerDisplayer;
    ShowFingers fingerScript;
    private void Awake() {
        dis = FindObjectOfType<DrumInputSystem>();
        dis.D1Single.AddListener(PressButton);
        dis.D1Double.AddListener(PressButton);
        dis.D1Triple.AddListener(PressButton);
        fingerDisplayer = GameObject.FindGameObjectWithTag("Fingers1");
        fingerScript = fingerDisplayer.GetComponent<ShowFingers>();
        script = FindObjectOfType<ScoreScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Activator1") {
            canBePressed = true;
        } else if (collision.tag == "DrumLine") {
            if (needed1Pressed == true) {
                fingerScript.fingerDisplay.Add(1);
            } else if (needed2Pressed == true) {
                fingerScript.fingerDisplay.Add(2);
            } else if (needed3Pressed == true) {
                fingerScript.fingerDisplay.Add(3);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Activator1") {
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

    private void OnDisable() {
        script.score += 100;
    }


    void PressButton(DrumInput d) {
        if (d == DrumInput.D1Single) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                singlePressed = true;
                CorrectlyPressed();
                if (canBePressed == true && correctlyPressed == true) {
                    destroyed = true;
                    Destroy(gameObject);
                }
            }
            singlePressed = false;

        } else if (d == DrumInput.D1Double) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                doublePressed = true;
                CorrectlyPressed();
                if (canBePressed == true && correctlyPressed == true) {
                    destroyed = true;
                    Destroy(gameObject);
                }
            }
            doublePressed = false;
        } else if (d == DrumInput.D1Triple) {
            for (float i = 0; i < 0.5f; i += Time.deltaTime) {
                triplePressed = true;
                CorrectlyPressed();
                if (canBePressed == true && correctlyPressed == true) {
                    destroyed = true;
                    Destroy(gameObject);
                }
            }
            triplePressed = false;
        }
    }
}
