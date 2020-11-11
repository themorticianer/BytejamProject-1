﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalVariables : MonoBehaviour
{
    public float health = 10;
    public float maxHealth = 10;
    public int killCount = 0;
    
    void Update()
    {
        
        if (health == 0) 
        {
            SceneManager.LoadScene("LossScene");
        }
    }

}
