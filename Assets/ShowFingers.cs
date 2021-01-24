using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowFingers : MonoBehaviour
{
    public Text fingers;

    public int fingerCount;
    public bool beatmapPlaying;
    public List<int> fingerDisplay = new List<int>();
    float displayTime;
    
    void Update()
    {
        if (beatmapPlaying == true) {
            foreach (int nr in fingerDisplay) {
                displayTime += Time.deltaTime;
                if (displayTime < 8) {
                    fingerCount = nr;
                } else continue;
            }

            fingers.text = fingerCount.ToString();

        } else {
            fingers.text = " ";
        }
    }
}
