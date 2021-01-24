using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFingerSpawner1 : MonoBehaviour
{
    public GameObject indicator;
    List<GameObject> beats = new List<GameObject>();
    public bool beatmapHasStarted;
    List<GameObject> indicators = new List<GameObject>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (beatmapHasStarted == true) {
            var objects = GameObject.FindGameObjectsWithTag("Beat");
            for(int i = 0; i < objects.Length; i++) {
                beats.Add(objects[i]);
            }
        } else {
            var deletable = GameObject.FindGameObjectsWithTag("Indicator");
            foreach(var b in deletable) {
                indicators.Add(b);
            }
            foreach(var x in indicators) {
                Destroy(x);
            }
        }

        foreach(var beat in beats) {
            var script = beat.GetComponent<NoteHolder>();
            if (script.hasIndicator == false) {
                Instantiate(indicator, beat.transform.position, Quaternion.identity);
                indicator.GetComponent<UiFingers>().host = beat;
                script.hasIndicator = true;
                continue;
            } else continue;
        }

        
    }
}
