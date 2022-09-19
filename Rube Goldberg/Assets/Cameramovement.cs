using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    public static bool zone1, zone2, zone3;
    public void StartMove()
    {
        StartCoroutine(LerpPosition());
    }
    IEnumerator LerpPosition()
    {
        float time = 0;
        float duration;
        while (zone1 == false)
        {
            yield return null;
        }

        time = 0;
        duration = 2;
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = new Vector3(0, -9.5f, -10);
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;

        while (zone2 == false)
        {
            yield return null;
        }

        time = 0;
        duration = 2;
        startPosition = transform.position;
        targetPosition = new Vector3(0, -19f, -10);
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;


        while (zone3 == false)
        {
            yield return null;
        }

        time = 0;
        duration = 6.5f;
        startPosition = transform.position;
        targetPosition = new Vector3(0, -63f, -10);
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;

    }
}
