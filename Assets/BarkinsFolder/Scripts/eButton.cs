using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eButton : MonoBehaviour
{
    public GameObject eButtonImage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (eButtonImage != null)
            {
                eButtonImage.SetActive(true);
            }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (eButtonImage != null)
            eButtonImage.SetActive(false);

        }
    }
}
