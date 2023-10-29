using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public Animator tree;
    private Animator anim;
    bool isPlayerInThisCollision = false;
    public GameObject treeObj;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayerInThisCollision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayerInThisCollision=false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&isPlayerInThisCollision)
        {
            StartCoroutine(StartGrowingTree());
        }
    }

    IEnumerator StartGrowingTree()
    {
        anim.SetTrigger("Seed");
        yield return new WaitForSeconds(0.5f);
        tree.SetTrigger("Growth");
        yield return new WaitForSeconds(1f);
        Destroy(tree.gameObject);
        treeObj.SetActive(true);
   
    }
}
