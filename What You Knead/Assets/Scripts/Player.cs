﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
