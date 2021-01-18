using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardDrumInput : MonoBehaviour
{
    public List<KeyCode> keys;

    DrumInputSystem dis;

    List<KeyCode> pressedButtons;

    enum DrumID { One, Two, Three, Undecided };

    // Start is called before the first frame update
    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            dis.EnterInput(DrumInput.D1Single);

        for (int i = 0; i < keys.Count; i++) {
            if (Input.GetKeyDown(keys[i])) {
                dis.EnterInput((DrumInput)i);
            }
        }

    //    for (int i = 0; i < keys.Count; i++) {
    //        if (Input.GetKeyDown(keys[i])) {
    //            pressedButtons.Add(keys[i]);
    //        }
    //    }

    //    if (pressedButtons.Count > 0) {
    //        float timer = 0.2f;
    //        timer -= Time.deltaTime;

    //        if ((timer < 0) && pressedButtons.Count == 1) {
    //            DrumID x = new DrumID();
    //            RaycastHit(x);

                
    //        } else if ((timer < 0) && pressedButtons.Count == 2) {

    //        } else if ((timer < 0) && pressedButtons.Count >= 3) {

    //        }
    //    }
    //}

    //void RaycastHit(DrumID id) {
    //    RaycastHit hit;
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    if (Physics.Raycast(ray, out hit)) {
    //        if (hit.collider != null) {
    //            var name = hit.collider.gameObject.name;
    //            if (name == "DrumOne") {
    //                id = DrumID.One;
    //                return;
    //            } else if (name == "DrumTwo") {
    //                id = DrumID.Two;
    //                return;
    //            } else if (name == "DrumThree") {
    //                id = DrumID.Three;
    //                return;
    //            }
    //        }
    //    }
    }
}
