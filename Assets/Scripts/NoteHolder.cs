using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHolder : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    void Update()
    {
        if (!hasStarted) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                hasStarted = true;
            }
        }
        else {
            transform.position += new Vector3((-1 * beatTempo * Time.deltaTime), 0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "DrumLine") {
            var spr = gameObject.GetComponent<SpriteRenderer>();
            spr.enabled = true;
        } else if (collision.tag == "Delete") {
            print("Missed One");
            Destroy(gameObject);

        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "DrumLine") {
            var spr = gameObject.GetComponent<SpriteRenderer>();
            spr.enabled = false;
        }
    }
}
