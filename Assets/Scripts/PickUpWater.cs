using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWater : MonoBehaviour
{
    

    public GameObject WaterBucket;

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
                    
           WaterBucket.SetActive(true);
            }
        }


    }



}
