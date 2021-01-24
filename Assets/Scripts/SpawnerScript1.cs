using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool startSpawn;
    public GameObject beat;
    public float ellapsedTime;
    float startTime;
    float songTime;
    List<float> playTimes = new List<float>();
    public List<float> timeStamps = new List<float>();
    

    void Start()
    {
        ellapsedTime += Time.deltaTime;
        timeStamps.Add(12);
        timeStamps.Add(15);
        timeStamps.Add(16);

    }

    // Update is called once per frame
    void Update()
    {
        if (startSpawn == true) {
            startTime = ellapsedTime;
            songTime += Time.deltaTime;
            for (int i = 0; i < timeStamps.Count; i++) {
                var playTime = startTime + timeStamps[i];
                playTimes.Add(playTime);
            }

            for (int i = 0; i < playTimes.Count; i++) {
                if (songTime == playTimes[i]) {
                    Instantiate(beat, gameObject.transform.position, Quaternion.identity);
                    var script = beat.GetComponent<BeatIndicatorScriptD1>();
                    if (i == 12) {
                        script.needed1Pressed = true;
                    } else {
                        script.needed2Pressed = true;
                    }
                    var nh = beat.GetComponent<NoteHolder>();
                    nh.hasStarted = true;
                }
            }
        } else {
            if (startTime != 0) {
                startTime = 0;
            } else if (songTime != 0) {
                songTime = 0;
            } else if (playTimes.Count > 0) {
                playTimes.Clear();
            }

        }

    }
}
