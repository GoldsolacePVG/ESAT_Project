﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int lives_ = 3;
    public Image[] heart;
    private bool is_immortal_ = false;
    private float immortal_counter = 100.0f;

    void Update(){
        if(is_immortal_){
            immortal_counter--;
        }
        if(immortal_counter <= 0){
            immortal_counter = 100.0f;
            is_immortal_ = false;
        }
    }

    public void TakePlayerDamage(int value){
        if(!is_immortal_){
            is_immortal_ = true;
            lives_ -= value;
            heart[lives_].enabled = false;
            if(lives_ <= 0){
                lives_ = 0;
                Destroy(gameObject);
            }
        }
    }
}
