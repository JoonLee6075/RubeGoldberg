using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public GameObject ball;
    public Transform location;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

           var cball = Instantiate(ball, location.position, location.rotation);
            cball.GetComponent<Rigidbody2D>().velocity = transform.up * 5f;
            cball.GetComponent<Rigidbody2D>().velocity = transform.right * 30f;

        }
    }
}
