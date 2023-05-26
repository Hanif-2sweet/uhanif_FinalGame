using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTimer : MonoBehaviour
{

    public GameObject WaterBucket;

    [SerializeField]
    private float timerSpeed = 5f;

    private float lastTimestamp;
    
    private void Update()
    { 
        if (Time.time - lastTimestamp >= timerSpeed)
        {
            lastTimestamp = Time.time;
            WaterBucket.SetActive(false);

        }
    }

}
