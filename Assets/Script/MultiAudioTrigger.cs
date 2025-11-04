using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MultiAudioTrigger : MonoBehaviour
{
    [Header("1. ลากป้าย UI Text (sub) มาใส่")]
    public Text subtitleText;

    [Header("2. ตั้งค่าเสียงและข้อความ (ใส่ได้หลายอัน)")]
    public SubtitleClip[] subtitleClips;

    private bool hasTriggered = false;

    [System.Serializable]
    public class SubtitleClip
    {
        public AudioClip audioClip;
        [TextArea(3, 5)]
        public string subtitleMessage;
        public float displayDuration = 3f;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;

            StartCoroutine(PlaySubtitlesSequentially());
        }
    }

    IEnumerator PlaySubtitlesSequentially()
    {
        if (subtitleText != null)
        {
            subtitleText.gameObject.SetActive(false);
        }

        yield return new WaitForSeconds(1f);

        foreach (var clip in subtitleClips)
        {
            if (subtitleText != null)
            {
                subtitleText.text = clip.subtitleMessage;
                subtitleText.gameObject.SetActive(true);
            }

            if (clip.audioClip != null)
            {
                AudioSource.PlayClipAtPoint(clip.audioClip, transform.position);
            }

            yield return new WaitForSeconds(clip.displayDuration);
        }

        if (subtitleText != null)
        {
            subtitleText.gameObject.SetActive(false);
        }

    }
}
