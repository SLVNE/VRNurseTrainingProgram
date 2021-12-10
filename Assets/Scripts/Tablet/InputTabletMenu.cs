using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTabletMenu : MonoBehaviour
{   
    
    public InputActionReference toggleReference = null;
    private GameObject rightHand;
    private GameObject stetHead;
    private GameObject handPump;
    private Vector3 initialScale;
    private bool stetHeadWasactive = false;
    private bool pumpWasActive = false;

    // Start is called before the first frame update
    private void Start() {
        gameObject.SetActive(false);
        rightHand = GameObject.Find("RightHand");
        stetHead = GameObject.Find("Chest_Piece_Hand");
        handPump = GameObject.Find("Tube_Hand");
    }

    private void Awake()
    {   
        toggleReference.action.started += Toggle;
    }

    public void OnDestroy() {
        toggleReference.action.started -= Toggle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Toggle function
    private void Toggle(InputAction.CallbackContext context) {
        bool isActive = !gameObject.activeSelf;
        // check for the state, if the tablet needs to be turned on continue the if statement
        if(isActive) {
            initialScale = rightHand.transform.localScale;
            rightHand.transform.localScale = new Vector3(0, 0, 0);
            rightHand.SetActive(false);
            if(stetHead.activeSelf) {
                stetHeadWasactive = true;
                stetHead.SetActive(false);
            }
            if(handPump.activeSelf) {
                pumpWasActive = true;
                handPump.SetActive(false);
            }
        } // else do this
        else {
            rightHand.SetActive(true);
            rightHand.transform.localScale = initialScale;
            // check if any of the other tools were used prior to accessing the menu
            if(stetHeadWasactive) {
                stetHead.SetActive(true);
                stetHeadWasactive = false;
            }
            if(pumpWasActive) {
                handPump.SetActive(true);
                pumpWasActive = false;
            }
        }
        gameObject.SetActive(isActive);
    }
}
