using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickenabled : MonoBehaviour
{
    public GameObject objects;
    public GameObject objects2;
    public bool inReach;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
        }
    }
    void Enable(){
        objects.SetActive(true);
        objects2.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (inReach && Input.GetButtonDown("Click"))
        {
            Enable();
        }
    }
}