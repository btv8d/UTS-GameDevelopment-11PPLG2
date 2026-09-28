<<<<<<< HEAD
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private int skor = 0;

    [Header("Status Koin")]
    public int totalKoin;
    private int koinTerkumpul = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        Enemy.OnZombieMati += TambahSkorSaatZombieMati;
    }

    void OnDisable()
    {
        Enemy.OnZombieMati -= TambahSkorSaatZombieMati;
    }

    void Start()
    {
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;
        Debug.Log("Total koin di scene: " + totalKoin);
    }

    void TambahSkorSaatZombieMati(Enemy enemyZombieYangMati)
{
    skor += 10; 
    Debug.Log("Skor = " + skor);
}

    public void AmbilKoin()
    {
        koinTerkumpul++;

        if (koinTerkumpul >= totalKoin)
        {
            Menang();
        }
    }

    void Menang()
    {
        Debug.Log("KAMU MENANG!");
    }
=======
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private int skor = 0;

    [Header("Status Koin")]
    public int totalKoin;
    private int koinTerkumpul = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        Enemy.OnZombieMati += TambahSkorSaatZombieMati;
    }

    void OnDisable()
    {
        Enemy.OnZombieMati -= TambahSkorSaatZombieMati;
    }

    void Start()
    {
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;
        Debug.Log("Total koin di scene: " + totalKoin);
    }

    void TambahSkorSaatZombieMati(Enemy enemyZombieYangMati)
{
    skor += 10; 
    Debug.Log("Skor = " + skor);
}

    public void AmbilKoin()
    {
        koinTerkumpul++;

        if (koinTerkumpul >= totalKoin)
        {
            Menang();
        }
    }

    void Menang()
    {
        Debug.Log("KAMU MENANG!");
    }
>>>>>>> ceb4c6a6 (selesai tugas unity)
}