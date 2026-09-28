<<<<<<< HEAD
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    [Header("Pengaturan Pergerakan")]
    public float kecepatan = 5f;

    [Header("Sistem Skor")]
    public int skor = 0;

    private Vector2 arahGerak; 

    void OnMove(InputValue value)
    {
        arahGerak = value.Get<Vector2>();
    }

    void Update()
    {
        
        Vector3 arah = new Vector3(arahGerak.x, arahGerak.y, 0);
        transform.position += arah * kecepatan * Time.deltaTime;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Coin"))
        {
            
            Destroy(other.gameObject);

            
            skor++;

            
            Debug.Log("Skor Saat Ini: " + skor);

        
            if (GameManager.instance != null)
            {
                GameManager.instance.AmbilKoin();
            }
        }
    }
=======
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    [Header("Pengaturan Pergerakan")]
    public float kecepatan = 5f;

    [Header("Sistem Skor")]
    public int skor = 0;

    private Vector2 arahGerak; 

    void OnMove(InputValue value)
    {
        arahGerak = value.Get<Vector2>();
    }

    void Update()
    {
        
        Vector3 arah = new Vector3(arahGerak.x, arahGerak.y, 0);
        transform.position += arah * kecepatan * Time.deltaTime;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Coin"))
        {
            
            Destroy(other.gameObject);

            
            skor++;

            
            Debug.Log("Skor Saat Ini: " + skor);

        
            if (GameManager.instance != null)
            {
                GameManager.instance.AmbilKoin();
            }
        }
    }
>>>>>>> ceb4c6a6 (selesai tugas unity)
}