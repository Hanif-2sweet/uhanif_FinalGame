using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public GameObject player;
private FirstPersonController fpsController;

public class RunGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Finds the First Person Controller script on the Player
		fpsController = player.GetComponent<FirstPersonController> ();
        fpsController.enabled = false;
    }

private void StartGame()
{
    fpsController.enabled = true;
}


public void FinishedGame()
	{
		
		isFinished = true;
		fpsController.enabled = false;
	}



    // Update is called once per frame
    void Update()
    {
        
    }
}
