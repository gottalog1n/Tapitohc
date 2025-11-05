using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToEnding: MonoBehaviour
{
    public Image black;
    public Animator fade;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Ending");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
