using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    public float speed;
    public Transform targetpos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, targetpos.position) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetpos.position, Time.deltaTime * speed);
        }
    }
}
