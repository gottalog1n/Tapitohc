using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderEnabled : MonoBehaviour
{
    public Collider[] triggerCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player"))
        {
            foreach (Collider collider in triggerCollider)
            {
                collider.enabled = true;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
