using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumFeedbackAnimation : MonoBehaviour
{
    float timer = 0;
    Transform drumPos;
     void Start() {
        //Drum's original position
        drumPos = gameObject.transform;

    }
    public void DrumTap(){
        while(timer < 5f) {
            drumPos.Translate(0, -0.5f * Time.deltaTime, 0, Space.Self);
        }
    }

}
