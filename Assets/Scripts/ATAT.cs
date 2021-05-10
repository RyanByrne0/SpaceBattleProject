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
        Fall();

    }

    public float death = 10;
    public void Fall()
    {
        death -= Time.deltaTime;
        if (gameObject.CompareTag("MainATAT") && death <= 0 && this.transform.rotation.z < 80)
        {
            
            transform.Rotate(0, 0, 11 * Time.deltaTime);

            
        }

        if (gameObject.CompareTag("MainATAT") && death <= 0)
        {

            transform.Translate(0, -2.5f * Time.deltaTime, 0);
        }




    }
}













