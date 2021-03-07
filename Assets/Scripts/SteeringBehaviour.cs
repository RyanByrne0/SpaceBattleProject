﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[RequireComponent (typeof(Ship))]
public abstract class SteeringBehaviour: MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public Ship ship;

    public void Awake()
    {
       ship = GetComponent<Ship>();
    }

    public abstract Vector3 Calculate();
}

