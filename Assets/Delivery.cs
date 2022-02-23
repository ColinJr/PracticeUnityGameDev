using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.5f;
    [SerializeField] public bool hasPackage = false;

    [SerializeField] public int score = 0;
    // Start is called before the first frame update
    public void Start() {
        Debug.Log(hasPackage);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision Detected");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            hasPackage = true;
            Debug.Log("Package picked up, score is " + score + ".");
            Destroy(other.gameObject, destroyDelay);

        }

        if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            score++;
            Debug.Log("Package Dropped Off, score is " + score + ".");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
