using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pump_Controller : MonoBehaviour
{
    Animator animator;
    public static float gripCurrent;
    public static string animatorGripParam;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat(animatorGripParam, gripCurrent);
    }
}
