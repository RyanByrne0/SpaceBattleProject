using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : SteeringBehaviour
{

    public Path path;
    public Path path2;

    Vector3 nextWaypoint;

   

    public void Start()
    {
        
    }

    private void Update()
    {
       
    }


    public override Vector3 Calculate()
    {
        nextWaypoint = path.NextWaypoint();
        if (Vector3.Distance(transform.position, nextWaypoint) < 25)
        {
            path.AdvanceToNext();
        }

        if (!path.looped && path.IsLast())
        {
            path = path2;
            return ship.ArriveForce(nextWaypoint, 20);
        }
        else
        {
            return ship.SeekForce(nextWaypoint);
        }
    }

    
}
