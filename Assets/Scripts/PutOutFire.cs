using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PutOutFire : MonoBehaviour
{
    

    public GameObject WaterBucket;
    public UnityEvent outFire;
    

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Water")
        {
            
            if (Input.GetKey(KeyCode.E))
            {
                outFire.Invoke();
                this.gameObject.SetActive(false);
                
            }
         
        }


    }



}