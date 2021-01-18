using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    // checks which sound should be played
    DrumInputSystem dis;
    float hitTime = 0.2f;
    public List<DrumInput> drumInputs;
    int amountOfHits = 0;

    // Start is called before the first frame update

    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //check how many hits on collider inside a certain timeframe
        for (int i= 0; i < Input.touchCount; i++) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[i].position);
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider != null) {
                    MultipleHitsEnable(hit.collider);
                }
            }
        }


    }
    
    void MultipleHitsEnable(Collider c) {
        var cScript = c.gameObject.GetComponent<SoundScript>();
        cScript.amountOfHits += 1;
        while (cScript.amountOfHits > 0) {
            cScript.hitTime -= Time.deltaTime;
            if (cScript.hitTime < 0) {
                if(amountOfHits == 1) {
                    dis.EnterInput(cScript.drumInputs[0]);
                    cScript.amountOfHits = 0;
                }
                else if (amountOfHits == 2) {
                    dis.EnterInput(cScript.drumInputs[1]);
                    cScript.amountOfHits = 0;
                }
                else if (amountOfHits > 2) {
                    dis.EnterInput(cScript.drumInputs[2]);
                    cScript.amountOfHits = 0;
                }
                cScript.hitTime = 0.2f;
            }
        }
    }
}
