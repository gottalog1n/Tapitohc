using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour
{
    public GameObject objects;
    public GameObject objects2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            objects2.SetActive(false);
            objects.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
