using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiFingers : MonoBehaviour
{
    public GameObject host;
    BeatIndicatorScriptD1 scp1;
    BeatIndicatorScriptD2 scp2;
    BeatIndicatorScriptD3 scp3;
    bool foundScript = false;
    Component script = new Component();
    public Text fingerindicator;



    private void Update() {
        transform.position += host.transform.position;
        if(foundScript == false) {
            scp1 = host.GetComponent(typeof(BeatIndicatorScriptD1)) as BeatIndicatorScriptD1;
            scp2 = host.GetComponent(typeof(BeatIndicatorScriptD2)) as BeatIndicatorScriptD2;
            scp3 = host.GetComponent(typeof(BeatIndicatorScriptD3)) as BeatIndicatorScriptD3;
            if (scp1 != null) {
                script = scp1;
                fingerindicator.text = "1";
                foundScript = true;
            } else if (scp2 != null) {
                script = scp2;
                fingerindicator.text = "2";
                foundScript = true;
            } else if (scp3 != null) {
                script = scp3;
                fingerindicator.text = "3";
                foundScript = true;
            } else Debug.Log("Didnt find script");
        }

        if (script == scp1) {
            if (scp1.destroyed == true) {
                Destroy(gameObject);
            }
        } else if (script == scp2) {
            if (scp2.destroyed == true) {
                Destroy(gameObject);
            }
        } else if (script == scp3) {
            if (scp3.destroyed == true) {
                Destroy(gameObject);
            }
        }

    }

}
