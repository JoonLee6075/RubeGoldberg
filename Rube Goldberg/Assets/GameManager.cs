using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float time;
    public GameObject UItime,  ball;
    private bool IsPress;
    void Start()
    {
        time = 0;
        IsPress = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPress)
        {
            time += Time.deltaTime;
            UItime.GetComponent<Text>().text = time.ToString();
        }
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            this.GetComponent<Cameramovement>().StartMove();
            IsPress = true;
            ball.SetActive(true);
        }
    }
}
