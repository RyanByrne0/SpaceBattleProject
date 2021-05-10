using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] cams;

    public float countdown = 60;

    public void Update()
    {
        CameraSwitching();
    }

    public void CameraSwitching()
    {
        countdown -= Time.deltaTime;

        if(countdown >= 50 && countdown < 60)
        {
            cams[0].SetActive(true);
            cams[1].SetActive(false);
            cams[2].SetActive(false);
            cams[3].SetActive(false);
        }
        if (countdown >= 45 && countdown < 49)
        {
            cams[0].SetActive(false);
            cams[1].SetActive(true);
            cams[2].SetActive(false);
            cams[3].SetActive(false);
        }
        if (countdown >= 30 && countdown < 44)
        {
            cams[0].SetActive(true);
            cams[1].SetActive(false);
            cams[2].SetActive(false);
            cams[3].SetActive(false);
        }
        if (countdown >= 20 && countdown < 29)
        {
            cams[0].SetActive(false);
            cams[1].SetActive(false);
            cams[2].SetActive(false);
            cams[3].SetActive(true);
        }
    }
}
