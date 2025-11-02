using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject linkedLight;

    private bool playerIsNear = false;

    void Update()
    {
        if (playerIsNear && Input.GetKeyDown(KeyCode.E))
        {
            ToggleLight();
        }
    }

    void ToggleLight()
    {
        if (linkedLight != null)
        {
            linkedLight.SetActive(!linkedLight.activeSelf);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsNear = false;
        }
    }
}
