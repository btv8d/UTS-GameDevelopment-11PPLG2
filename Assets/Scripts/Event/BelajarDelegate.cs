<<<<<<< HEAD
using UnityEngine;
using System;

public class BelajarDelegate : MonoBehaviour
{
    public delegate void AksiDelegate();

    void Start()
    {
        CobaDelegate();
    }

    void CobaDelegate()
    {
        AksiDelegate halo = PanggilHalo;
        halo += PanggilWorld; // Menggabungkan dua method sekaligus
        halo();               // Menjalankan keduanya secara berurutan
    }

    void PanggilHalo()
    {
        Debug.Log("Halo");
    }

    void PanggilWorld()
    {
        Debug.Log("World");
    }
=======
using UnityEngine;
using System;

public class BelajarDelegate : MonoBehaviour
{
    public delegate void AksiDelegate();

    void Start()
    {
        CobaDelegate();
    }

    void CobaDelegate()
    {
        AksiDelegate halo = PanggilHalo;
        halo += PanggilWorld; // Menggabungkan dua method sekaligus
        halo();               // Menjalankan keduanya secara berurutan
    }

    void PanggilHalo()
    {
        Debug.Log("Halo");
    }

    void PanggilWorld()
    {
        Debug.Log("World");
    }
>>>>>>> ceb4c6a6 (selesai tugas unity)
}