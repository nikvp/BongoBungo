using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardDrumInput : MonoBehaviour
{
    public List<KeyCode> keys;

    DrumInputSystem dis;

    // Start is called before the first frame update
    void Awake()
    {
        dis = FindObjectOfType<DrumInputSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //    dis.EnterInput(DrumInput.D1Single);

        for (int i = 0; i < keys.Count; i++) {
            if (Input.GetKeyDown(keys[i])) {
                dis.EnterInput((DrumInput)i);
            }
        }
    }
}
