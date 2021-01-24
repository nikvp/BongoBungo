using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public string[] audioID;
    public Collider coll;
    SpawnerScript1 spsc1;
    SpawnerScript2 spsc2;
    SpawnerScript3 spsc3;
    bool startedBeatmap = false;
    List<GameObject> beats = new List<GameObject>();
    void Awake()
    {
        spsc1 = spawner1.GetComponent<SpawnerScript1>();
        spsc2 = spawner2.GetComponent<SpawnerScript2>();
        spsc3 = spawner3.GetComponent<SpawnerScript3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startedBeatmap == false) {
            for (int i = 0; i < Input.touchCount; i++) {
                if (Input.touches[0].phase == TouchPhase.Began) {
                    for (int x = 0; x < audioID.Length; x++) {
                        AudioFW.PlayLoop(audioID[x]);
                    }
                    Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                    RaycastHit hit;
                    if (coll.Raycast(ray, out hit, 100f)) {
                        spawner1.SetActive(true);
                        spawner2.SetActive(true);
                        spawner3.SetActive(true);
                        spsc1.startTime = Time.time;
                        spsc2.startTime = Time.time;
                        spsc3.startTime = Time.time;
                    }
                    startedBeatmap = true;
                }
            }
        } else if (startedBeatmap == true) {
            for (int i = 0; i < Input.touchCount; i++) {
                if (Input.touches[0].phase == TouchPhase.Began) {
                    for (int x = 0; x < audioID.Length; x++) {
                        AudioFW.StopLoop(audioID[x]);
                    }
                    Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                    RaycastHit hit;
                    if (coll.Raycast(ray, out hit, 100f)) {
                        spawner1.SetActive(false);
                        spawner2.SetActive(false);
                        spawner3.SetActive(false);
                        var tag = GameObject.FindGameObjectsWithTag("Beat");
                        for (int y = 0; y < tag.Length; y++) {
                            beats.Add(tag[y].gameObject);
                        }
                        for (int z = 0; z < beats.Count; z++) {
                            Destroy(beats[z]);
                        }
                        startedBeatmap = false;
                    }
                }
            }
        }
    }
}
