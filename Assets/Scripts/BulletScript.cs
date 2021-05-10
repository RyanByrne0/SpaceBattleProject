using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float speed = 160;

    public void Start()
    {
        Destroy(this.gameObject, 3);
    }

    public void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

 
}

