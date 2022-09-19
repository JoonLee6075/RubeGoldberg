using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Cameramovement.zone1 = true;
    }
}
