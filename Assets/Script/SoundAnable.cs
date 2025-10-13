using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAnable : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public Collider triggerCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {   
            audioSource.Play();
            audioSource2.Play();
            Debug.Log("Player entered the trigger");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            triggerCollider.enabled = false;
        }
        Debug.Log("Player exited the trigger");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
