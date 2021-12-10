using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BP_Grade_Compare : MonoBehaviour
{   
    // private Dropdown systDropdownMenu;
    // private Dropdown diastDropdownMenu;
    private Text verdict;
    // private Text systResult;
    // private Text diastResult;
    // private int prevIndex;
    // Start is called before the first frame update
    void Start()
    {
        //prevIndex = rotateArrow.getPrevIndex();
        // systDropdownMenu = GameObject.Find("Systolic_Dropdown").GetComponent<Dropdown>();
        // diastDropdownMenu = GameObject.Find("Diastolic_Dropdown").GetComponent<Dropdown>();
         verdict = GameObject.Find("Verdict").GetComponent<Text>();
        // systResult = GameObject.Find("BP_Answer__Systolic_Pressure").GetComponent<Text>();
        // diastResult = GameObject.Find("BP_Answer__Diastolic_Pressure").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // bool compareValues() {
    //     bool same;
    //     if((systDropdownMenu.value-1 == prevIndex) && (diastDropdownMenu.value-1 == prevIndex)) {
    //         same = true;
    //     }
    //     else {
    //         same = false;
    //     }
    //     return same;
    // }

    // public void computeResults() {
    //     if(compareValues()) {
    //         verdict.text = "Correct!";
    //         systResult.text = systDropdownMenu.options[prevIndex].text;
    //         diastResult.text = diastDropdownMenu.options[prevIndex].text;
    //     }
    //     else {
    //         verdict.text = "Incorrect!";
    //         systResult.text = systDropdownMenu.options[prevIndex].text;
    //         diastResult.text = diastDropdownMenu.options[prevIndex].text;
    //     }
    // }

    public void functieTest() {
        verdict.text = "CRT!";
    }
}
