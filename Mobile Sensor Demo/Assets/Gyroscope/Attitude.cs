using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attitude : MonoBehaviour
{

    Gyroscope gyro;

    private void Start() {
        gyro = Input.gyro;
        gyro.enabled = true;
    }
    

    private void Update() {
        gameObject.transform.rotation = gyro.attitude;
    }
}
