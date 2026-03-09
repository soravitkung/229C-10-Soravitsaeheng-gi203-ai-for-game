using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [Header("Settings")]
    public float speed = 20f; // ความเร็วของยาน

    void Update()
    {
        // ทำให้ยานเคลื่อนที่ไปข้างหน้าตามทิศทางของตัวเอง (Local Forward)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}