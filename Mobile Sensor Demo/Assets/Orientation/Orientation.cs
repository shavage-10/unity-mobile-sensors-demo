using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Orientation : MonoBehaviour
{
    private void Start() {
        // InputSystem.EnableDevice(UnityEngine.InputSystem.Accelerometer.current);
        InputSystem.EnableDevice(UnityEngine.InputSystem.Accelerometer.current);
    }

    private void Update() {
        Debug.Log(UnityEngine.InputSystem.Accelerometer.current);
        // Debug.Log(Input.deviceOrientation);
        // Debug.Log(UnityEngine.InputSystem.LinearAccelerationSensor.current.enabled);
    }
}
