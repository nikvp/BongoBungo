using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumOneInput : MonoBehaviour
{
    DrumInputSystem dis;
    public Collider coll;
    List<RaycastHit> amountOfHits = new List<RaycastHit>();

    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++) {
            if (Input.touches[i].phase == TouchPhase.Began) {
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[i].position);
                RaycastHit hit;
                if(coll.Raycast(ray, out hit, 100f)) {
                    amountOfHits.Add(hit);
                    print("HitD1");
                }
            }
        }

        if (amountOfHits.Count > 0) {
            print("D1 Hits: " + amountOfHits.Count);
            float timer = 0.2f;
            timer -= Time.deltaTime;
            if (timer < 0) {
                if (amountOfHits.Count == 1) {
                    dis.EnterInput((DrumInput)0);
                }else if (amountOfHits.Count == 2) {
                    dis.EnterInput((DrumInput)1);
                } else if (amountOfHits.Count >= 3) {
                    dis.EnterInput((DrumInput)2);
                }
            }
            amountOfHits.Clear();
        }
    }
}
