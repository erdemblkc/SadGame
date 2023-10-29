using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMesh : MonoBehaviour
{
    public Transform hedefNesne; // Yaklaþýlmak istenen nesne
    public TextMeshProUGUI metinBaloncugu; // TextMesh Pro elemaný
    public float yaklasmaMesafesi = 2f; // Panelin görünmeye baþlamasý için gerekli mesafe

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

