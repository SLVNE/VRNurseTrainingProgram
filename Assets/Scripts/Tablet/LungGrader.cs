using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LungGrader : MonoBehaviour
{
    public Text verdictLung; 
    public Text lungResult;
    private int prev;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void button0() {
        prev = StethoscopeCode.getPrev();
        if(prev == 0) {
            verdictLung.text = "Correct!";
            lungResult.text = "Normal Function";
        }
        else {
            verdictLung.text = "Incorect!";
            lungResult.text = "Wheezing problem";
        }
    }

    public void button1() {
        prev = StethoscopeCode.getPrev();
        if(prev == 1) {
            verdictLung.text = "Correct!";
            lungResult.text = "Wheezing problem";
        }
        else {
            verdictLung.text = "Incorect!";
            lungResult.text = "Normal Function";
        }
    }
}
