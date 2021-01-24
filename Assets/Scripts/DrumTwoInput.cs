using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumTwoInput : MonoBehaviour
{
    DrumInputSystem dis;
    public GameObject gm;
    public Collider coll;
    List<RaycastHit> amountOfHits = new List<RaycastHit>();

    void Awake() {
        dis = gm.GetComponent<DrumInputSystem>();
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < Input.touchCount; i++) {
            if (Input.touches[i].phase == TouchPhase.Began) {
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[i].position);
                RaycastHit hit;
                if (coll.Raycast(ray, out hit, 100f)) {
                    amountOfHits.Add(hit);
                    //print("HitD3");
                }
            }

        }
        if (amountOfHits.Count > 0) {
            if (amountOfHits.Count == 1) {
                dis.EnterInput((DrumInput)6);
                print("D3Single");
            } else if (amountOfHits.Count == 2) {
                dis.EnterInput((DrumInput)7);
                print("D3Double");
            } else if (amountOfHits.Count >= 3) {
                print("D3Triple");
                dis.EnterInput((DrumInput)8);
            }
            amountOfHits.Clear();
            //print("D1 Hits: " + amountOfHits.Count);
        }
    }
}
