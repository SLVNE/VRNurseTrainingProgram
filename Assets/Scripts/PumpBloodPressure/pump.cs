using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class pump : MonoBehaviour
{   
    private static bool isDecrement = false;
    private static double counter = 0;
    public AudioClip selectEnterSound;
    public static Coroutine _current;
    
    public void PlaySelectEnterSound() {
        if((selectEnterSound != null) && (counter < 10)) {
            AudioSource.PlayClipAtPoint(selectEnterSound, transform.position);
            if(counter > 9) {
                counter = 10;
            }
            else {
                counter++;
            }
        }
    }

    // Accessor
    public static double getCounter() {
        return counter;
    }
    public static bool isDecrementing() {
        return isDecrement;
    }

    // Other Methods
    public void resetCounter() {
        StartCoroutine("decrementCounter");
    }

    public void beginDecrementing() {
        isDecrement = true;
        if(_current != null) StopCoroutine(_current);
        _current = StartCoroutine(decrementCounter());
    }

    public void stopDecrementing() {
        isDecrement = false;
        if(_current != null) StopCoroutine(_current);
        _current = null;
    }

    IEnumerator decrementCounter() {
        AudioSource.PlayClipAtPoint(selectEnterSound, transform.position);
        while(counter > 0) {
            if(counter < 0.1) {
                counter = 0;
                isDecrement = false;
            }
            else {
                counter = counter-0.1;
            }
            yield return new WaitForSeconds((float) 0.3);
        }
    }
}
