﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVillageStage : MonoBehaviour
{
    public GameObject character;

    public void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            DontDestroyOnLoad(character);
            SceneManager.LoadScene("VillageEndScene");
        }
    }
}