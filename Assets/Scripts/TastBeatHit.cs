using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TastBeatHit : MonoBehaviour
{
    public bool canBePressed;
    void Update()
    {
        //if (canBePressed == true) {

        //}
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Activator1") {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Activator1") {
            canBePressed = false;
        }
    }
}
