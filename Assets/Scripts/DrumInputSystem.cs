using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum DrumInput { D1Single, D1Double, D1Triple, D2Single, D2Double, D2Triple, D3Single, D3Double, D3Triple };

public class DrumInputSystem : MonoBehaviour
{
    public UnityEvent<DrumInput> anythingInput;

    public UnityEvent D1Single;
    public UnityEvent D1Double;
    public UnityEvent D1Triple;
    public UnityEvent D2Single;
    public UnityEvent D2Double;
    public UnityEvent D2Triple;
    public UnityEvent D3Single;
    public UnityEvent D3Double;
    public UnityEvent D3Triple;

    //public UnityEvent drum1Input;
    //public UnityEvent drum2Input;
    //public UnityEvent drum3Input;

    //List<DrumInput> drum1Inputs = new List<DrumInput> { DrumInput.D1Single, DrumInput.D1Double, DrumInput.D1Triple };
    //List<DrumInput> drum2Inputs = new List<DrumInput> { DrumInput.D2Single, DrumInput.D2Double, DrumInput.D2Triple };
    //List<DrumInput> drum3Inputs = new List<DrumInput> { DrumInput.D3Single, DrumInput.D3Double, DrumInput.D3Triple };

    public void EnterInput(DrumInput d) {
        anythingInput.Invoke(d);
        if (d == DrumInput.D1Single) {
            D1Single.Invoke();
            print("D1Single");
        } else if (d == DrumInput.D2Single) {
            D2Single.Invoke();
            print("D2Single");
        } else if (d == DrumInput.D3Single) {
            D3Single.Invoke();
            print("D3Single");
        } else if (d == DrumInput.D1Double) {
            D1Double.Invoke();
            print("D1Double");
        } else if (d == DrumInput.D2Double) {
            D2Double.Invoke();
            print("D2Double");
        } else if (d == DrumInput.D3Double) {
            D3Double.Invoke();
            print("D3Double");
        } else if (d == DrumInput.D1Triple) {
            D1Triple.Invoke();
            print("D1Triple");
        } else if (d == DrumInput.D2Triple) {
            D2Triple.Invoke();
            print("D2Triple");
        } else if (d == DrumInput.D3Triple) {
            D3Triple.Invoke();
            print("D3Triple");
        }
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
