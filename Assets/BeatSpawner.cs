using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject beat;
    NoteHolder nh;
    private void OnEnable() {
        Instantiate(beat, transform.position, Quaternion.identity);
        nh = beat.GetComponent<NoteHolder>();
        nh.hasStarted = true;
        gameObject.SetActive(false);
    }
    

}
