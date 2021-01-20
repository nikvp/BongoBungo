using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    List<GameObject> beats = new List<GameObject>();

    public Collider coll;
    void Awake()
    {
        var beatTags = GameObject.FindGameObjectsWithTag("Beat");
        for (int i = 0; i < beatTags.Length; i++) {
            beats.Add(beatTags[i].gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++) {
            if (Input.touches[0].phase == TouchPhase.Began) {
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;
                if (coll.Raycast(ray, out hit, 100f)) {
                    for (int x = 0; x < beats.Count; x++) {
                        var scrp = beats[x].GetComponent<NoteHolder>();
                        scrp.hasStarted = true;
                    }
                }
            }
        }
    }
}
