using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WallTrigger : MonoBehaviour
{
    public GameObject wall;
    public GameObject com;
    public GameObject trigger;
    public Image whiteScreen; // ใส่ Image สีขาวจาก Canvas
    public float fadeDuration = 5f; // เวลาจางลง (หน่วยเป็นวินาที)

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(wall);
            Destroy(com);
            StartCoroutine(WhiteFlashThenFade());
        }
    }

    private IEnumerator WhiteFlashThenFade()
    {
        // ให้จอขาวทันที
        whiteScreen.color = new Color(1f, 1f, 1f, 1f);

        // รอแป๊บเดียวก่อนเริ่มจาง (เช่น 0.2 วินาที)
        yield return new WaitForSeconds(0.8f);

        // ค่อยๆ จางลงใน 3 วิ
        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, t / fadeDuration);
            whiteScreen.color = new Color(1f, 1f, 1f, alpha);
            yield return null;
        }

        // ให้แน่ใจว่า alpha = 0 ตอนจบ
        whiteScreen.color = new Color(1f, 1f, 1f, 0f);
        Destroy(trigger);
    }
    
}
