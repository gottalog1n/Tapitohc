using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCondition : MonoBehaviour
{
    public Animator fade;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger!");
            StartCoroutine(Fading());
        }
    }

    IEnumerator Fading()
    {
        Debug.Log("Start Fading coroutine");
        if (fade != null)
        {
            fade.SetBool("Fade", true);
        }
        else
        {
            Debug.LogWarning("No Animator assigned to 'fade'!");
        }

        yield return new WaitForSeconds(1f);

        Debug.Log("Loading scene 'Condition'...");
        SceneManager.LoadScene("Condition");
    }
}