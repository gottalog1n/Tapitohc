using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{
    public Animator door;
    public bool isOpen = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isOpen = true;
            DoorCloses();
            Debug.Log("Player entered the trigger");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void DoorCloses()
    {
        if (isOpen) // Only close if it's open
        {
            Debug.Log("It Closes");
            door.SetBool("Open", false);
            door.SetBool("Closed", true);
            //if (closeSound) closeSound.Play();
            isOpen = false;
        }
    }
}
