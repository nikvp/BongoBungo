using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatIndicatorScriptD1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canBePressed;
    //GameObject dIndicator;
    //IndicatorScript1 ids1;
    public DrumInput neededDrum;

    // Update is called once per frame
    void Update()
    {
        //if (canBePressed == true) {
        //    //if (ids1.beingPressed == true) {
        //    //    CheckIfRightDrum();
             
        //}
    }
    private void OnTriggerEnter2D(Collider2D col) {
        //if (col.tag == "Activator1") {
        //    dIndicator = col.gameObject;
        //    ids1 = dIndicator.GetComponent<IndicatorScript1>();
        //    canBePressed = true;
        //}
    }

    private void OnTriggerExit2D(Collider2D col) {
        //if (col.tag == "Activator1") {
        //    canBePressed = false;
        //}
    }

    //void CheckIfRightDrum() {
    //    if (ids1.pressedDrum == neededDrum) {
    //        Destroy(gameObject);
    //        //give points and do some effects
    //    } else {
    //        print("Wrong drum");
    //    }
    //}
}
