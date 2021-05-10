﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{

    public List<Vector3> waypoints = new List<Vector3>();
    public List<Transform> trasformWaypoints;

    public int next = 0;
    public bool looped = true;

  
    void Start()
    {
        waypoints.Clear();
        int count = transform.childCount;
     

        if (trasformWaypoints != null)
        {
            for(int i = 0; i < trasformWaypoints.Count; i++)
            {
                waypoints.Add(trasformWaypoints[i].position);
            }
           
        }

        for (int i = 0; i < count; i++)
        {
            waypoints.Add(transform.GetChild(i).position);
        }
    }

   
    void Update(){    }

    public Vector3 NextWaypoint()
    {
        return waypoints[next];
    }

    public void AdvanceToNext()
    {
        if (looped)
        {
            next = (next + 1) % waypoints.Count;
        }
        else
        {
            if (next != waypoints.Count - 1)
            {
                next++;
            }
        }
    }
    public bool IsLast()
    {
        return next == waypoints.Count - 1;
    }
}
