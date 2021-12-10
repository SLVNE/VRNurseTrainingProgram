using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StethoscopeCode : MonoBehaviour
{   
    private AudioSource chestSound;
    public AudioClip[] breathing;
    public bool playStethoscope = false;
    GameObject stet_head;
    public static Coroutine _chest;
    private static int prev;
    private int ind;
    // Start is called before the first frame update
    void Start()
    {
        chestSound = GetComponent<AudioSource>();
        ind = Random.Range(0, breathing.Length);
        chestSound.clip = breathing[ind];
        stet_head = GameObject.Find("Chest_Piece_Hand");   
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    // function to detect collisions
    public void playChestSounds() {
        //if(_chest != null) StopCoroutine(_chest);
        //_chest = StartCoroutine(chestSounds());
        chestSound.Play();
        playStethoscope = true;
    }

    public void stopChestSounds() {
        //if(_chest != null) StopCoroutine(_chest);
        //_chest = null;
        chestSound.Stop();
        prev = ind;
        playStethoscope = false;
        ind = Random.Range(0, breathing.Length);
        chestSound.clip = breathing[ind];
    }

    IEnumerator chestSounds() {
        while(playStethoscope) {
            chestSound.Play();
            yield return new WaitForSeconds(chestSound.clip.length + (float)0.1);
            //chestSound.Stop(); 
            
        }
    }

    public static int getPrev() {
        return prev;
    }
}
