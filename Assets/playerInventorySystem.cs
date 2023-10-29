using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerInventorySystem : MonoBehaviour
{
    public bool hasKey = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "key")
        {
            hasKey = true;
            Destroy(collision.gameObject);
        }
    }
}