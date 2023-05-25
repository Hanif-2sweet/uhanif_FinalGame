using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBucket : MonoBehaviour
{
    

    public GameObject WBPlayer;

    // Start is called before the first frame update
    void Start()
    {
        WBPlayer.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                WBPlayer.SetActive(true);
            }
        }


    }



}
