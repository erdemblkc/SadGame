using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuy : MonoBehaviour
{
    public GameObject portal; // The cheese object attached to the tree
    private bool portalopen = false;
    public GameObject mouse;
    public GameObject camera;

    public Animator catAnim;

    public GameObject eButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            portalopen = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            portalopen = false;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && portalopen)
        {
            StartCoroutine(PortalGet());
            mouse.SetActive(true);
            camera.GetComponent<Animator>().SetTrigger("CameraZoomOut");
            catAnim.SetTrigger("Interact");
            Destroy(eButton);
        }
    }

    private IEnumerator PortalGet()
    {
        portalopen = false;

        // Deactivate the cheese object
        portal.SetActive(true);

        yield return new WaitForSeconds(0.3f); // Adjust the delay as needed

        // Reactivate the cheese object
        portal.SetActive(true);

        portalopen = false;
    }
}

