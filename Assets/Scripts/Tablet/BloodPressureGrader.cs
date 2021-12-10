using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodPressureGrader : MonoBehaviour
{   
    public Text verdict; 
    public Text systResult;
    public Text diastResult;
    public Dropdown systDropdownMenu;
    public Dropdown diastDropdownMenu;
    private int prevIndex;
    

    // Start is called before the first frame update
    void Awake()
    {
        prevIndex = rotateArrow.getPrevIndex();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool compareValues() {
        bool same;
        prevIndex = rotateArrow.getPrevIndex() + 1;
        if((systDropdownMenu.value == prevIndex) && (diastDropdownMenu.value == prevIndex)) {
            same = true;
        }
        else {
            same = false;
        }
        return same;
    }

    public void computeResults() {
        if(compareValues()) {
            verdict.text = "Correct!";
        }
        else {
            verdict.text = "Incorrect!";
        }
            systResult.text = "Systolic pressure = " + systDropdownMenu.options[prevIndex].text + " (mmHg)";
            diastResult.text = "Diastolic pressure = " + diastDropdownMenu.options[prevIndex].text + " (mmHg)";
    }
}
