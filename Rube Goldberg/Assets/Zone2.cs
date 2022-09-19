using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Cameramovement.zone2 = true;
    }
}
