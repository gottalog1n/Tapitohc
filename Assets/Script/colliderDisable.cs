using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDisable : MonoBehaviour
{
    public Collider triggerCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player"))
        {
            triggerCollider.GetComponent<Collider>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
