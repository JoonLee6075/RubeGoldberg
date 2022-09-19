using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<SpriteRenderer>().color = new Color32(231 , 119 , 119 , 255);
        Debug.Log("sss");
    }
}
