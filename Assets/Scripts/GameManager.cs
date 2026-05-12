using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text tiempoText;

    void Update()
    {
        tiempoText.text = string.Format("{0:F2}s", Time.time);
    }
}