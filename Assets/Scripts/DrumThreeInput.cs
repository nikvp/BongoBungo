using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumThreeInput : MonoBehaviour
{
    DrumInputSystem dis;
    public Collider coll;
    public GameObject gm;
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
            //print("D3 Hits: " + amountOfHits.Count);
            float timer = 0.2f;
            timer -= Time.deltaTime;
            if (timer < 0) {
                if (amountOfHits.Count == 1) {
                    dis.EnterInput((DrumInput)6);
                } else if (amountOfHits.Count == 2) {
                    dis.EnterInput((DrumInput)7);
                } else if (amountOfHits.Count >= 3) {
                    dis.EnterInput((DrumInput)8);
                }
            }
            amountOfHits.Clear();
        }
    }
}
