using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryChest : MonoBehaviour
{
    public Sprite openChest;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            if (collision.gameObject.GetComponent<playerInventorySystem>().hasKey == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = openChest;
            }



        }
    }
}