using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientation : MonoBehaviour
{
    private void Update() {
        Debug.Log(Input.deviceOrientation);
    }
}
