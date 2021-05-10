using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATAT : MonoBehaviour
{
    public GameObject[] Cannons;
    public GameObject bullet;

    public float rateOfFire = 3;

    public float count = 3;

    public AudioSource shot;

    private void OnEnable()
    {
        StartCoroutine(ShootCoroutine());
    }

    public void Shooting()
    {
        count -= Time.deltaTime;
        Instantiate(bullet, Cannons[0].transform);
        Instantiate(bullet, Cannons[1].transform);
        shot.Play();
        
    }

    System.Collections.IEnumerator ShootCoroutine()
    {
        while (true)
        {
                Shooting();
               
                yield return new WaitForSeconds(Random.Range(3,6));
                
            
            yield return null;
        }
    }

    public void Update()
    {


    }

















}
