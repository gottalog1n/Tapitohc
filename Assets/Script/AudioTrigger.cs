using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AudioTrigger : MonoBehaviour
{
    [Header("1. ลากเครื่องเล่นเสียงมาใส่")]
    public AudioSource audioSource;

    [Header("2. ลากป้าย UI Text (ชื่อ sub) มาใส่")]
    public Text subtitleText;

    [Header("3. ตั้งค่าข้อความและเวลา")]
    [TextArea(3, 10)]
    public string subtitleMessage;
    public float displayDuration = 5f;


    private bool hasTriggered = false;


    void Start()
    {
        if (subtitleText != null)
        {
            subtitleText.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;

            StartCoroutine(ShowSubtitleAndPlaySound());
        }
    }

    IEnumerator ShowSubtitleAndPlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }

        if (subtitleText != null)
        {
            subtitleText.text = subtitleMessage;
            subtitleText.gameObject.SetActive(true); // สั่ง "เปิด" Text
        }

        yield return new WaitForSeconds(displayDuration);

        if (subtitleText != null)
        {
            subtitleText.gameObject.SetActive(false); // สั่ง "ปิด" Text
        }

    }
}
