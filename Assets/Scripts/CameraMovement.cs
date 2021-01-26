﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject player;

    Vector3 offset = new Vector3(0.0f, 5.51f, -5.76f);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Camera();
        }
    }

    private void Camera()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, 0.1f);
    }
}
