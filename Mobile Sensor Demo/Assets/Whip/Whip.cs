using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Whip : MonoBehaviour
{
    public AudioClip clip;
    public TMPro.TMP_Text text;
    private float speed = 7f;
    public float magnitude;
    private bool trigger;

    void Update()

    {
        // TODO: trigger sound effect when flicking the phone
        // To play the audio clip use GetComponent<AudioSource>().PlayOneShot(clip);

        // Update text to show acceleration values
        if (Input.acceleration.magnitude > speed){
            if (!trigger) {
                trigger = true;
                GetComponent<AudioSource>().PlayOneShot(clip);
            }

        } else if (trigger) {
            trigger = false;
        }

        if (text)
            text.text = "Acceleration " + Input.acceleration.ToString();
    }
}
