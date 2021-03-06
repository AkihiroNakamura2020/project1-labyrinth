﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fadeover : MonoBehaviour
{
    public float time;
    public float speed = 1.0f;
    Image image;
    void Start()
    {
        image = this.GetComponent<Image>();
    }

    void Update()
    {



        if (image.color.a >= 0)
        {
            image.color = GetAlphaColor(image.color);
        }
    }

    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 30.0f * speed;
        // color.a = Mathf.Sin(time) * 0.1f + 0.5f;
        color.a = time / 100 + 0.01f;
        return color;
    }
}