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



        
    }
}
