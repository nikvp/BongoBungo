using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript2 : MonoBehaviour
{
    public bool startSpawn;
    public GameObject beat;
    public float startTime;
    public float songTime;
    public List<float> timeStamps = new List<float>();


    void OnEnable() {
        timeStamps.Add(4);
        timeStamps.Add(8);
        timeStamps.Add(12);

    }
    private void Update() {
        songTime += Time.deltaTime;
        for (int i = 0; i < timeStamps.Count; i++) {
            if (songTime >= timeStamps[i]) {
                Instantiate(beat, gameObject.transform.position, Quaternion.identity);
                var script = beat.GetComponent<BeatIndicatorScriptD2>();
                if (i == 8) {
                    script.needed1Pressed = true;
                } else {
                    script.needed2Pressed = true;
                }
                var nh = beat.GetComponent<NoteHolder>();
                nh.hasStarted = true;
                timeStamps.RemoveAt(i);
            }
        }
    }

    void OnDisable() {
        startTime = 0;
        songTime = 0;
        timeStamps.Clear();
    }
}
