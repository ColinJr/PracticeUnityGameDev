using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float defaultSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float driveSpeed = 20f;
    [SerializeField] int powerTimer = 0;

    void Start()
    {
        
    }
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float gasPedal = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, gasPedal, 0);
        if (powerTimer == 1)
        {
            if (driveSpeed == boostSpeed)
            {
                Debug.Log("you're no longer boosting");

            }
            if (driveSpeed == slowSpeed)
            {
                Debug.Log("you're no longer slowed");
            }
            powerTimer--;
            driveSpeed = defaultSpeed;
        }
        if (powerTimer > 1)
        {
            powerTimer--;
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SpeedBoost")
        {
            driveSpeed = boostSpeed;
            powerTimer = 5000;
            Debug.Log("you're speed Boosting!!!");
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        driveSpeed = slowSpeed;
        powerTimer = 5000;
        Debug.Log("you're slowed down...");
    }


}
