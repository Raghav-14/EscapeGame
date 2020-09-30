using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public DeathMenu deathMenu;

    //touch inputes
    private Touch touch;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, Time.fixedDeltaTime * moveSpeed);
            }
            else if (touch.position.x > Screen.width / 2)
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, Time.fixedDeltaTime * -moveSpeed);
            }

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        deathMenu.ToggleEndMenu();
        GetComponent<ScoreController>().OnDeath();
    }
}


    
