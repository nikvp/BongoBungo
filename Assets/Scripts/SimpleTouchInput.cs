using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTouchInput : MonoBehaviour
{
    // Start is called before the first frame update
    DrumInputSystem dis;

    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider != null) {
                    Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = newColor;
                }
            }
        }
    }
}
