﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHODZI : MonoBehaviour
{
    public float speed = 3.5F;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1F * speed));
    }
}
