using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum DrumInput { D1Single, D1Double, D1Triple, D2Single, D2Double, D2Triple, D3Single, D3Double, D3Triple };

public class DrumInputSystem : MonoBehaviour
{
    public UnityEvent<DrumInput> anythingInput;

    public UnityEvent drum1Input;

    List<DrumInput> drum1Inputs = new List<DrumInput> { DrumInput.D1Single, DrumInput.D1Double, DrumInput.D1Triple };

    public void EnterInput(DrumInput d) {
        anythingInput.Invoke(d);
        print("Check");
        if (drum1Inputs.Contains(d))
            drum1Input.Invoke();
            
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
