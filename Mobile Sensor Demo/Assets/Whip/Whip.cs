using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Whip : MonoBehaviour
{
    public AudioClip clip;
    public TMPro.TMP_Text text;

    void Update()
    {
        // TODO: trigger sound effect when flicking the phone
        // To play the audio clip use GetComponent<AudioSource>().PlayOneShot(clip);

        // Update text to show acceleration values
        if(text)
            text.text = "Acceleration " + Input.acceleration.ToString();
    }
}
