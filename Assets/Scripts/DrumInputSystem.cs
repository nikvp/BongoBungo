using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum DrumInput { D1Single, D1Double, D1Triple, D2Single, D2Double, D2Triple, D3Single, D3Double, D3Triple };

public class DrumInputSystem : MonoBehaviour
{
    public UnityEvent<DrumInput> anythingInput;

    public UnityEvent drum1Input;
    public UnityEvent drum2Input;
    public UnityEvent drum3Input;

    List<DrumInput> drum1Inputs = new List<DrumInput> { DrumInput.D1Single, DrumInput.D1Double, DrumInput.D1Triple };
    List<DrumInput> drum2Inputs = new List<DrumInput> { DrumInput.D2Single, DrumInput.D2Double, DrumInput.D2Triple };
    List<DrumInput> drum3Inputs = new List<DrumInput> { DrumInput.D3Single, DrumInput.D3Double, DrumInput.D3Triple };

    public void EnterInput(DrumInput d) {
        anythingInput.Invoke(d);
        if (drum1Inputs.Contains(d))
            drum1Input.Invoke();
        else if (drum2Inputs.Contains(d))
            drum2Input.Invoke();
        else if (drum3Inputs.Contains(d))
            drum3Input.Invoke();
            
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
