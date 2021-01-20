using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatHitIndicator : MonoBehaviour
{
    // Start is called before the first frame update
    DrumInputSystem dis;
    public GameObject drumIndicator1;
    public GameObject drumIndicator2;
    public GameObject drumIndicator3;
    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
        dis.anythingInput.AddListener(PressButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PressButton(DrumInput d) {
        if (d == DrumInput.D1Single) {
            var scr1 = drumIndicator1.GetComponent<Testindicator1>();
            for (float i = 0; i < 0.2f; i += Time.deltaTime) {
                scr1.singlePressed = true;
                print("singlepressed1 true");
            }
            scr1.singlePressed = false;
            print("s1d1 nomore");

        } else if (d == DrumInput.D1Double) {
            var scr1 = drumIndicator1.GetComponent<Testindicator1>();
            for (float i = 0; i < 0.2f; i += Time.deltaTime) {
                scr1.doublePressed = true;
            }
            scr1.doublePressed = false;
        } else if (d == DrumInput.D1Triple) {
            var scr1 = drumIndicator1.GetComponent<Testindicator1>();
            for (float i = 0; i < 0.2f; i += Time.deltaTime) {
                scr1.triplePressed = true;
            }
            scr1.triplePressed = false;
        } else if (d == DrumInput.D2Single) {
            var scr2 = drumIndicator2.GetComponent<Testindicator2>();
            for (float i = 0; i < 0.1f; i += Time.deltaTime) {
                scr2.singlePressed = true;
            }
        } else if (d == DrumInput.D2Double) {
            var scr2 = drumIndicator2.GetComponent<Testindicator2>();
            for (float i = 0; i < 0.1f; i += Time.deltaTime) {
                scr2.doublePressed = true;
            }
        } else if (d == DrumInput.D2Triple) {
            var scr2 = drumIndicator2.GetComponent<Testindicator2>();
            for (float i = 0; i < 0.1f; i += Time.deltaTime) {
                scr2.triplePressed = true;
            }
        } else if (d == DrumInput.D3Single) {
            var scr3 = drumIndicator3.GetComponent<Testindicator3>();
            for (float i = 0; i < 0.1f; i += Time.deltaTime) {
                scr3.singlePressed = true;
            }
        } else if (d == DrumInput.D3Double) {
            var scr3 = drumIndicator3.GetComponent<Testindicator3>();
            for (float i = 0; i < 0.1f; i += Time.deltaTime) {
                scr3.doublePressed = true;
            }
        } else if (d == DrumInput.D3Triple) {
            var scr3 = drumIndicator3.GetComponent<Testindicator3>();
            for (float i = 0; i < 0.1f; i += Time.deltaTime) {
                scr3.triplePressed = true;
            }
        }
    }
}
