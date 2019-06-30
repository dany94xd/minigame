﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherryspauner : MonoBehaviour
{
    float timer;
    public GameObject cherryPrefab;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= 2f)
        {
            timer = 0;
            float x = Random.Range(-30f, 30f);
            Vector3 position = new Vector3(x, 0, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(cherryPrefab,position,rotation);
        }
    }
}
