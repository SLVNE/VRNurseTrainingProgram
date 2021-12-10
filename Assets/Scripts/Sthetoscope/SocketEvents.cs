using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketEvents : MonoBehaviour
{
    GameObject stet_head;
    GameObject right_hand;
    Vector3 initialScale; 
    // Start is called before the first frame update
    void Start()
    {
        stet_head = GameObject.Find("Chest_Piece_Hand");
        right_hand = GameObject.Find("RightHand");
        stet_head.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Make Chest Piece Inactive
    public void activateStethoscope() {
        stet_head.SetActive(true);
        initialScale = right_hand.transform.localScale;
        right_hand.transform.localScale = new Vector3(0, 0, 0);
    }

    public void deactivateSethoscope() {
        stet_head.SetActive(false);
        right_hand.transform.localScale = initialScale;
    }
}
