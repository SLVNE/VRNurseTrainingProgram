using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateArrow : MonoBehaviour
{   
    // declare the parameters and set them to defaul values for now
    private static int random_index;
    // both should be of equal length
    private static double[] systolic_pressures = new double[] {110, 120, 130, 140};
    private static double[] diastolic_pressures = new double[] {75, 80, 85, 90};
    // static variables to store the pressure values from the previous test
    //private static double prev_systolic_pressure = 110;
    //private static double prev_diastolic_pressure = 75;
    private static int prevIndex;

    public AudioClip pulse;
    private AudioSource Audio;

    private static bool isSoundActive = false;
    private static bool needsReset = false;
    public static Coroutine isBeating;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.clip = pulse;
        Audio.loop = true;
        // get a random index for the start systolic/diastolic values 
        random_index = Random.Range(0, systolic_pressures.Length);
        //prevIndex = random_index;
    }

    // Update is called once per frame
    void Update()
    {   
        // collect the counter value and convert it into degrees 1 degree = 1.125mmHg on the dial
        double v = pump.getCounter()*16; // 0 when counter == 0, 160 on the dial when counter == 10
        // check if the blood pressure is whithin the given systolic and diastolic rates 
        // if yes, start the routine     // stretch/convert blood pressure to "degrees" on the display
        if((v >= diastolic_pressures[random_index]*160/180) && (v <= systolic_pressures[random_index]*160/180) && pump.isDecrementing()) {
            if(isBeating == null) {
                isBeating = StartCoroutine(playPulse());
                isSoundActive = true;
                needsReset = true;
            }
        } // if no or out of bounds stop the routine 
        else {
            isSoundActive = false;
            if(isBeating != null) {
                StopCoroutine(isBeating);
                isBeating = null;
            }
            if(needsReset && v < diastolic_pressures[0]) { // generate new random variables
                prevIndex = random_index;
                random_index = Random.Range(0, systolic_pressures.Length);
                needsReset = false;
            }
        }

        Vector3 newRotation = new Vector3(0, 0, (float) v + 95);
        transform.localEulerAngles = newRotation;
    }

    IEnumerator playPulse() {
        while(true) {
            AudioSource.PlayClipAtPoint(pulse, transform.position);
            yield return new WaitForSeconds(1);
        }
    }

    public static int getPrevIndex() {
        return prevIndex;
    }
}
