using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMesh : MonoBehaviour
{
    public Transform hedefNesne; // Yakla��lmak istenen nesne
    public TextMeshProUGUI metinBaloncugu; // TextMesh Pro eleman�
    public float yaklasmaMesafesi = 2f; // Panelin g�r�nmeye ba�lamas� i�in gerekli mesafe

    private void Update()
    {
        float mesafe = Vector3.Distance(transform.position, hedefNesne.position);

        if (mesafe < yaklasmaMesafesi)
        {
            metinBaloncugu.gameObject.SetActive(true);
        }
        else
        {
            metinBaloncugu.gameObject.SetActive(false);
        }
    }
}

