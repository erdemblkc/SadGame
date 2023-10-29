using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryChest : MonoBehaviour
{
    public Sprite openChest;
    public bool hasEntered = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasEntered = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasEntered = false;

        }
    }
    private void Update()
    {
            if (playerInventorySystem.Instance.hasKey&&Input.GetKeyDown(KeyCode.E)&&hasEntered)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite=openChest;    
        }
    }
}