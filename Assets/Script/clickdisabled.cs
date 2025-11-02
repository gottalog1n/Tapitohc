using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickdisabled : MonoBehaviour
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
    void Disable(){
        objects.SetActive(false);
        objects2.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (inReach && Input.GetButtonDown("Click"))
        {
            Disable();
        }
    }
}