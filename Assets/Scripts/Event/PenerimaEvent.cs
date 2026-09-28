<<<<<<< HEAD
using UnityEngine;

public class PenerimaEvent : MonoBehaviour
{
    void OnEnable()
    {
        PemancarEvent.OnTekanSpasi += Reaksi;
    }

    void OnDisable()
    {
        PemancarEvent.OnTekanSpasi -= Reaksi;
    }

    void Reaksi()
    {
        Debug.Log("Penerima: aku dengar event spasi!");
    }
}
=======
using UnityEngine;

public class PenerimaEvent : MonoBehaviour
{
    void OnEnable()
    {
        PemancarEvent.OnTekanSpasi += Reaksi;
    }

    void OnDisable()
    {
        PemancarEvent.OnTekanSpasi -= Reaksi;
    }

    void Reaksi()
    {
        Debug.Log("Penerima: aku dengar event spasi!");
    }
}
>>>>>>> ceb4c6a6 (selesai tugas unity)
