using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript3 : MonoBehaviour
{
    public bool startSpawn;
    public GameObject beat;
    public float startTime;
    public float songTime;
    public List<float> timeStamps = new List<float>();


    void OnEnable() {
        timeStamps.Add(1);
        timeStamps.Add(2);
        timeStamps.Add(5);
        timeStamps.Add(6);
        timeStamps.Add(9);
        timeStamps.Add(10);
        timeStamps.Add(13);
        timeStamps.Add(14);
        timeStamps.Add(15.5f);
        timeStamps.Add(16.5f);

    }
    private void Update() {
        songTime += Time.deltaTime;
        for (int i = 0; i < timeStamps.Count; i++) {
            if (songTime >= timeStamps[i]) {
                Instantiate(beat, gameObject.transform.position, Quaternion.identity);
                var script = beat.GetComponent<BeatIndicatorScriptD3>();
                if (i == 15.5) {
                    script.needed2Pressed = true;
                } else if (i == 16.5) {
                    script.needed2Pressed = true;
                } else {
                    script.needed1Pressed = true;
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
