using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Whip : MonoBehaviour
{
    public AudioClip clip;
    public float thresh = 3;
    public TMPro.TMP_Text text;
    private bool trigger = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.acceleration.magnitude > thresh) {
            if (!trigger) {
                trigger = true;
                GetComponent<AudioSource>().PlayOneShot(clip);
            }
        } else if (trigger) {
            trigger = false;
        }
        if(text)
            text.text = Input.acceleration.ToString();
    }
}
