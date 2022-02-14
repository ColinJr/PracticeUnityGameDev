using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
