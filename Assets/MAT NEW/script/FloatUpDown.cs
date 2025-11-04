using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUpDown : MonoBehaviour
{
    public float amplitude = 0.5f; // ระยะที่ลอยขึ้นลง
    public float speed = 2f;       // ความเร็วในการลอย
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // จำตำแหน่งเริ่มต้นไว้
    }

    void Update()
    {
        // ใช้ Sine wave ทำให้มันขึ้นลงอย่างนุ่มนวล
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
