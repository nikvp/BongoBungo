using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHolder : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    HealthScript script;
    ScoreScript score;
    public bool hasIndicator;

    private void Awake() {
        script = FindObjectOfType<HealthScript>();
        score = FindObjectOfType<ScoreScript>();
    }
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
            script.health--;
            score.score -= 100;
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
