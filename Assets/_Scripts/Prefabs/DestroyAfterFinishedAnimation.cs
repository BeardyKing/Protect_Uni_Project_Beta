﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterFinishedAnimation : MonoBehaviour{
    public float timer;

    void Update(){
        timer -= Time.deltaTime;
        if (timer <= 0) {
            Destroy(gameObject);
        }
    }
}
