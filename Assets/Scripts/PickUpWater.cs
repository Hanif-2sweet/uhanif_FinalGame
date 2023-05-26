using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickUpWater : MonoBehaviour
{
    

    public GameObject WaterBucket;
    public UnityEvent fillWater;

    // Start is called before the first frame update
    void Start()
    {
        WaterBucket.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
          if (Input.GetKey(KeyCode.E))
            {                   
                fillWater.Invoke();
                WaterBucket.SetActive(true);
            }
        }


    }



}
