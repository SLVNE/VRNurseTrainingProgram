using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodPressureEvents : MonoBehaviour
{   
    GameObject bp_pump;
    GameObject hand_pump;
    Vector3 initialScale; 
    // Start is called before the first frame update
    void Start()
    {
        bp_pump = GameObject.Find("Tube");
        hand_pump = GameObject.Find("Tube_Hand");   
        hand_pump.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // function to hide/unhide stethoscope and mount pump in the user's hand
    public void activatePressurePump() {
        bp_pump.SetActive(false);   
        hand_pump.SetActive(true);
    }

    public void deactivatePressuePump() {
        bp_pump.SetActive(true);
        hand_pump.SetActive(false);
    }
}
