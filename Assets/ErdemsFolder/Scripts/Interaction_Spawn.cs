using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction_Spawn : MonoBehaviour
{
    public GameObject cheese; // The cheese object attached to the tree
    private bool cheeseFalling = false;

    public GameObject mainsprite;
    public Sprite agizacik;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            cheeseFalling = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            cheeseFalling = false;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && cheeseFalling)
        {
            StartCoroutine(DropCheese());
            //mainsprite.GetComponent<SpriteRenderer>().sprite = agizacik;
        }
    }

    private IEnumerator DropCheese()
    {
        cheeseFalling = false;

        // Deactivate the cheese object
        cheese.SetActive(true);

        yield return new WaitForSeconds(0.3f); // Adjust the delay as needed

        // Reactivate the cheese object
        cheese.SetActive(true);

        cheeseFalling = false;
    }
}

