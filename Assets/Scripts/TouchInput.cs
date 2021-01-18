using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    List<RaycastHit> drum1Hits;
    List<RaycastHit> drum2Hits;
    List<RaycastHit> drum3Hits;
    DrumInputSystem dis; 
    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //check the inputs and add hits to each drumhitcount
        for (int i = 0; i < Input.touchCount; i++) {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[i].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider != null) {
                    var name = hit.collider.gameObject.name;
                    if (name == "DrumOne") {
                        drum1Hits.Add(hit);
                    } else if (name == "DrumTwo") {
                        drum2Hits.Add(hit);
                    } else if (name == "DrumThree") {
                        drum3Hits.Add(hit);
                    }
                }
            }
        }
        //if we have a hit check how many hits and play the correct sound
        AmountOfHitsd1();
        AmountOfHitsd2();
        AmountOfHitsd3();
    }

    void AmountOfHitsd1() {
        if (drum1Hits.Count > 0) {
            float timer = 0.2f;
            timer -= Time.deltaTime;
            if (timer < 0) {
                if (drum1Hits.Count == 1) {
                    dis.EnterInput((DrumInput)0);
                } else if (drum1Hits.Count == 2) {
                    dis.EnterInput((DrumInput)1);
                } else if (drum1Hits.Count >= 3) {
                    dis.EnterInput((DrumInput)2);
                }
                drum1Hits.Clear();
            }
        } else print("No hit D1");
    }
    void AmountOfHitsd2() {
        if (drum2Hits.Count > 0) {
            float timer = 0.2f;
            timer -= Time.deltaTime;
            if (timer < 0) {
                if (drum2Hits.Count == 1) {
                    dis.EnterInput((DrumInput)3);
                } else if (drum2Hits.Count == 2) {
                    dis.EnterInput((DrumInput)4);
                } else if (drum2Hits.Count >= 5) {
                    dis.EnterInput((DrumInput)2);
                }
                drum2Hits.Clear();
            }
        } else print("No hit D2");
    }
    void AmountOfHitsd3() {
        if (drum1Hits.Count > 0) {
            float timer = 0.2f;
            timer -= Time.deltaTime;
            if (timer < 0) {
                if (drum3Hits.Count == 1) {
                    dis.EnterInput((DrumInput)6);
                } else if (drum3Hits.Count == 2) {
                    dis.EnterInput((DrumInput)7);
                } else if (drum3Hits.Count >= 3) {
                    dis.EnterInput((DrumInput)8);
                }
                drum3Hits.Clear();
            }
        } else print("No hit D3");
    }
}
